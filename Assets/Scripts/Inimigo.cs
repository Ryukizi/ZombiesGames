using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour
{

    public NavMeshAgent nmaInmigo;
    public Transform jogador;

    public Animator inimigoAnimator;

    public Transform maoInimigo;

    public bool pegoJogador = false;

    public Jogo scriptJogo;

    public AudioSource fonteAudio;

    public AudioClip[] clipsAudio;

    float contador;

    float intervalo = 4;

    public void OnTriggerEnter(Collider objetoQueColidiu)
    {
        if(objetoQueColidiu.gameObject.tag == "jogador")
        {
            inimigoAnimator.SetTrigger("pegoJogador");

            jogador.SetParent(maoInimigo);
            jogador.position = maoInimigo.position;
            jogador.transform.GetComponent<Rigidbody>().isKinematic = true;
            pegoJogador = true;
            scriptJogo.jogadorFoiPego = true;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;

        if(contador > intervalo)
        {
            fonteAudio.PlayOneShot(clipsAudio[Random.Range(0, clipsAudio.Length)]);
            intervalo = Random.Range(3, 12);
            contador = 0;
        }

        if (!pegoJogador)
        {
            nmaInmigo.destination = jogador.position;
        }
        
    }
}
