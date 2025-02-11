using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class TypeTextAnimations : MonoBehaviour
{
    public float typeDelay = 0.5f;
    public TextMeshProUGUI textObject;

    public string fullText;

    internal void StartTyping()
    {
        throw new NotImplementedException();
    }

    void Start()
    {
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        textObject.text = fullText;
        textObject.maxVisibleCharacters = 0;
        for(int i = 0; i <= textObject.text.Length; i++)
        {
            textObject.maxVisibleCharacters = i;
            yield return new WaitForSeconds(typeDelay);
        }
    }
}
