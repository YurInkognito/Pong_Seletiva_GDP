using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class IntroScene : MonoBehaviour
{
    [TextArea(5, 10)]
    public string fullText;

    public TextMeshProUGUI introText;
    public GameObject continueButton;
    public float textSpeed = 0.05f;

    private bool isSkipping = false;

    void Start()
    {
        introText.text = "";
        continueButton.SetActive(false);
        StartCoroutine(ShowText());
    }

    void Update()
    {
        isSkipping = Input.GetKey(KeyCode.Space);
    }

    IEnumerator ShowText()
    {
        foreach (char letter in fullText)
        {
            introText.text += letter;
            yield return new WaitForSeconds(isSkipping ? textSpeed / 2 : textSpeed);
        }

        continueButton.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("PongGame");
    }
}
