using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(1, 1).normalized * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle")) // Rebate na raquete
        {
            Vector2 ballPosition = transform.position;
            Vector2 paddlePosition = collision.transform.position;

            float difference = ballPosition.x - paddlePosition.x;
            float angle = difference * 4f;

            Vector2 newDirection = new Vector2(angle, 1).normalized;
            rb.linearVelocity = newDirection * speed;
        }
        else if (collision.gameObject.CompareTag("Wall")) // Rebate nas paredes
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y); 
        }
    }
}
