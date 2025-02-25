using UnityEngine;

public class Jogador : MonoBehaviour
{
    public Rigidbody jogador;

    public float velocidade;

    public Jogo scriptJogo;

    public float eixoX;

    public float eixoY;

    public float correr;
    public void OnTriggerEnter(Collider objetoQueColidu)
    {
        if(objetoQueColidu.gameObject.tag == "Saida")
        {
            scriptJogo.jogadorEscapou = true;
            Time.timeScale = 0;
        }
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        eixoX = Input.GetAxis("Horizontal");
        eixoY = Input.GetAxis("Vertical");
        correr = Input.GetAxis("Fire3") * velocidade * 3;

        Vector3 Andando = jogador.linearVelocity = new Vector3(eixoX* velocidade, jogador.linearVelocity.y, eixoY * velocidade);

        if (correr > 0)
        {
            Andando = jogador.linearVelocity = new Vector3(eixoX * correr, jogador.linearVelocity.y, eixoY * correr);
        }

    }
}

