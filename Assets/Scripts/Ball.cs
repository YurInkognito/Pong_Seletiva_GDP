using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float velocidadeDaBola;

    public float direcaoAleatoriaX;
    public float direcaoAleatoriaY;

    public Rigidbody2D oRigidbody2D;

    public AudioSource somDaBola;

    void Start()
    {
        MoverBola();
    }
    private void MoverBola()
    {
        oRigidbody2D.linearVelocity = new Vector2(5f, 5f);
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        somDaBola.Play();
        oRigidbody2D.linearVelocity += new Vector2(direcaoAleatoriaX, direcaoAleatoriaY);
    }
}
