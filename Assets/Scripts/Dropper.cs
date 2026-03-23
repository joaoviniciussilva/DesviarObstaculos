using UnityEngine;

public class Dropper : MonoBehaviour
{
   
    [SerializeField]float TempoDeEspera = 2f;
    MeshRenderer meuMeshRenderer;
    Rigidbody meuRigidbody;

    void Start()
    {
        meuMeshRenderer = GetComponent<MeshRenderer>();
        meuRigidbody = GetComponent<Rigidbody>();
        
        meuMeshRenderer.enabled = false;
        meuRigidbody.useGravity = false;

    }

    void Update()
    {
        if (Time.time > TempoDeEspera)
        {
            meuMeshRenderer.enabled = true;
            meuRigidbody.useGravity = true;
        }
    }
}
