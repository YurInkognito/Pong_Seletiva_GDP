using UnityEngine;

public class DialogueStarter : MonoBehaviour
{
    public DialogueData dialogueData;

    void Start()
    {
        DialogueSystem dialogueSystem = Object.FindFirstObjectByType<DialogueSystem>();

        if (dialogueSystem != null)
        {
            dialogueSystem.StartDialogue();
        }
        else
        {
            Debug.LogError("DialogueSystem não encontrado na cena!");
        }
    }
}
