using JetBrains.Annotations;
using UnityEngine;

public class SeguirJogador : MonoBehaviour
{
    

    public Transform seguidor;
    public Transform alvo;
    public Vector3 distancia;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seguidor.position = alvo.position + distancia;
    }
}
