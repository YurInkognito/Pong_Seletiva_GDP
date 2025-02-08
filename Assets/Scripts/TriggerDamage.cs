using UnityEngine;

public class Barrier : MonoBehaviour
{
    public int dano = 1; // Quantidade de dano que a barreira causa ao ser atingida

    [System.Obsolete]
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bola"))
        {
            HeartSystem playerLife = FindObjectOfType<HeartSystem>();

            if (playerLife != null)
            {
                playerLife.vida -= dano; // Reduz a vida do player
            }
        }
    }
}
