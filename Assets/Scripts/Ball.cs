using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float velocidadeDaBola;

    public float direcaoAleatoriaX;
    public float direcaoAleatoriaY;

    public Rigidbody2D oRigidbody2D;

    public AudioSource somDaBola;

    public GameObject objetoReset;
    public float tempoDeContato = 0f;
    private bool emContato = false;

    private float tempoDeVelocidade = 0f;
    private float incrementoDeVelocidade = 1f;

    void Start()
    {
        MoverBola();
    }

    void Update()
    {
        tempoDeVelocidade += Time.deltaTime;

        if (tempoDeVelocidade >= 3f)
        {
            velocidadeDaBola += incrementoDeVelocidade;
            tempoDeVelocidade = 0f;
            Debug.Log("Velocidade aumentada");
            //MoverBola();
        }
    }
    private void MoverBola()
    {
        oRigidbody2D.linearVelocity = new Vector2(5f, 5f);
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.gameObject == objetoReset)
        {
            emContato = true;
        }

        somDaBola.Play();
        oRigidbody2D.linearVelocity += new Vector2(direcaoAleatoriaX, direcaoAleatoriaY);

        if (emContato && collisionInfo.gameObject == objetoReset)
        {
            tempoDeContato += Time.deltaTime;

            if (tempoDeContato >= 2f)
            {
                ResetarBola();
                tempoDeContato = 0f;
            }
        }

        if (collisionInfo.gameObject == objetoReset)
        {
            emContato = true;
            tempoDeContato = 0f;
        }
    }

    private void ResetarBola()
    {
        Debug.Log("Bola resetada ");
        transform.position = Vector2.zero;
        oRigidbody2D.linearVelocity = Vector2.zero;
        MoverBola();
    }

}
