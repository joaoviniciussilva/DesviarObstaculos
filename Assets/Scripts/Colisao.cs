using UnityEngine;

public class Colisao : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Acerto";
        }
        
    }

}
