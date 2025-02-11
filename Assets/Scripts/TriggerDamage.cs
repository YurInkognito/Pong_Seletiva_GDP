using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDamage : MonoBehaviour
{
    public int dano = 1;
    public Vector2 respawnPoint = Vector2.zero;

    public HeartSystem heart;
    public string gameOverSceneName = "GameOverScene";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bola"))
        {

            heart.vida--;

            if (heart.vida <= 0)
            {
                Debug.Log("Game Over! Carregando cena...");
                Time.timeScale = 1f;
                SceneManager.LoadScene(gameOverSceneName);
                return;
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