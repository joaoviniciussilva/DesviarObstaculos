using UnityEngine;

public class Marcador : MonoBehaviour
{
    int Colisao = 0;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Acerto")
        {
            Colisao++;
            Debug.Log("Voce colidiu: " + Colisao + " vezes.");
        }
        
        
    }
}
