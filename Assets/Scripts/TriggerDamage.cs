using UnityEngine;

public class Barrier : MonoBehaviour
{
    public int dano = 1; 
    public Vector2 respawnPoint = Vector2.zero; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bola"))
        {
        
            HeartSystem playerLife = FindObjectOfType<HeartSystem>();
            if (playerLife != null)
            {
                playerLife.vida -= dano;
            }

            Ball ballScript = collision.gameObject.GetComponent<Ball>();

            if (ballScript != null)
            {
                Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.linearVelocity = Vector2.zero; 
                    rb.angularVelocity = 0f; 
                    collision.gameObject.transform.position = respawnPoint; 
                   
                    Vector2 direcao = new Vector2(1, 1).normalized; 
                    rb.linearVelocity = direcao * ballScript.velocidadeDaBola;
                }
            }
        }
    }
}
