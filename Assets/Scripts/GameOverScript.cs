using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject[] hudElements;
    public void gameOver()
    {
        Debug.Log("Game Over chamado!");

        foreach (GameObject obj in hudElements)
        {
            if (obj != null)
            {
                Debug.Log("Desativando: " + obj.name);
                obj.SetActive(false);
            }
        }

        gameOverUI.SetActive(true);
        Debug.Log("Game Over UI ativada!");

        Time.timeScale = 0f;
    }

    public void restart(string cena)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(cena);
    }

    public void mainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
