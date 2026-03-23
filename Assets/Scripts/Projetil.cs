using UnityEngine;

public class Projetil : MonoBehaviour
{
    [SerializeField] float velocidadeProjetil = 0.01f;
    [SerializeField] Transform player;
    Vector3 posicaoJogador;
    
    void Awake() 
    {
        gameObject.SetActive(false);
    }
    
    void Start()
    {
        posicaoJogador = player.transform.position;
    }

    void Update()
    {   
        MovaAteJogador();
        AutoDestruir(); 
    }
    
    void MovaAteJogador()
    {
         transform.position = 
        Vector3.MoveTowards(transform.position, posicaoJogador, Time.deltaTime * velocidadeProjetil);
    }
    
    void AutoDestruir()
    {
        if (transform.position == posicaoJogador)
        {
            Destroy(gameObject);
        }
        
    }
}
