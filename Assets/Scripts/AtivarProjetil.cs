using UnityEngine;

public class AtivarProjetil : MonoBehaviour
{
    [SerializeField] GameObject projetil1;
    [SerializeField] GameObject projetil2;
    [SerializeField] GameObject projetil3;
    [SerializeField] GameObject projetil4;
    [SerializeField] GameObject projetil5;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            projetil1.SetActive(true);
            projetil2.SetActive(true);
            projetil3.SetActive(true);
            projetil4.SetActive(true);
            projetil5.SetActive(true);
            Destroy(gameObject);
        }
    }
}
