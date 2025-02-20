using UnityEngine;

public class Jogador : MonoBehaviour
{
    public Rigidbody jogador;

    public float velocidade;

    public Jogo scriptJogo;

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
        float forcaHorizontal = Input.GetAxis("Horizontal");
        float forcaVertical = Input.GetAxis("Vertical");

        Vector3 direcaoDaForca = new Vector3(forcaHorizontal, 0, forcaVertical);

        jogador.AddForce(direcaoDaForca * velocidade);
    }
}

