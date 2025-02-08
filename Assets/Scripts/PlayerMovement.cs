using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerMovement : MonoBehaviour
{
    public float velocidadeDoJogador;
    
    public bool jogador1;

    public float xMinimo;
    public float xMaximo;

    public Camera mainCamera;

    public UnityEngine.Transform target;
    public float followSpeed = 5f;

    void Start()
    {

    }

    void Update()
    {
        if(jogador1 == true)
        {
            MoverJogador1();
        }
        else
        {
            MoverJogador2();
        }
    }

    private void MoverJogador1()
    {

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, xMinimo, xMaximo), transform.position.y);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * velocidadeDoJogador * Time.deltaTime);
        }

    }

    private void MoverJogador2()
    {

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, xMinimo, xMaximo), transform.position.y);

        if (target != null)
        {
            Vector3 currentPosition = transform.position;

            Vector3 targetPosition = new Vector3(target.position.x, currentPosition.y, currentPosition.z);

            transform.position = Vector3.Lerp(currentPosition, targetPosition, followSpeed * Time.deltaTime);
        }
        else
        {
            Debug.LogWarning("O alvo não foi atribuído ao objeto seguidor!");
        }
    }
}
