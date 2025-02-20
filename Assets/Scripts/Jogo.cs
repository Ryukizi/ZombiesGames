using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private int pontos;
    public int outrosPontos;
    public float peso;

    public GameObject painelDerrota;
    public GameObject painelVitoria;

    public bool jogadorFoiPego = false;
    public bool jogadorEscapou = false; 
    
    void Start  {
        Debug.Log("importante variaveis")
    }
    // Update is called once per frame
    void Update()
    {
        if (jogadorEscapou)
        {
            painelVitoria.SetActive(true);
        }
        if (jogadorFoiPego)
        {
            painelDerrota.SetActive(true);
        }
    }

    public void Recomecar()
    {
        int cenaAtual = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(cenaAtual);
    }

    public void Sair()
    {
        Application.Quit();
    }
}
