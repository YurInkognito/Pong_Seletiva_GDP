using UnityEngine;
using UnityEngine.UI;

public class Player1Health : MonoBehaviour
{
    public int life;
    public int lifeMax = 5;

    public Image[] coracao;
    public Sprite cheio;
    public Sprite vazio;

    private bool isDead = false;
    public GameObject gameOverScreen;

    public void TakeDamage(int amount)
    {
        if (isDead) return;

        life -= amount;
        if (life < 0) life = 0;

        UpdateHealthUI();

        if (life <= 0 && !isDead)
        {
            isDead = true;
            gameObject.SetActive(false);
            CallGameOver();
        }
    }

    private void UpdateHealthUI()
    {
        for (int i = 0; i < coracao.Length; i++)
        {
            if (i < life)
            {
                coracao[i].sprite = cheio;
                coracao[i].enabled = true;
            }
            else
            {
                coracao[i].sprite = vazio;
                coracao[i].enabled = false;
            }
        }
    }

    private void CallGameOver()
    {
        if (gameOverScreen != null) gameOverScreen.SetActive(true);
        Debug.Log("Player 1 perdeu!");
    }
}
