using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        MostrarIntrucoes();
    }

    void Update()
    {
        MovimentacaoDoPersonagem();
    }

    void MostrarIntrucoes()
    {
        Debug.Log("Bem vindo ao jogo!");
        Debug.Log("Para se movimentar no jogo utilize as setas ou as teclas WASD");
        Debug.Log("Para vencer o jogo você deve desviar dos obstaculos para chegar até a linha de chegada");
    }

    void MovimentacaoDoPersonagem()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }

}