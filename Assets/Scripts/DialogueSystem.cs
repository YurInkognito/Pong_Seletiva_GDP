using UnityEngine;

public enum STATE
{
    DISABLE,
    WAITING,
    TYPING
}

public class DialogueSystem : MonoBehaviour
{
    public DialogueData dialogueData;

    int currentText = 0;
    bool finished = false;

    TypeTextAnimations typeText;
    DialogueUI dialogueUI;

    STATE state;

    void Awake()
    {
        typeText = Object.FindFirstObjectByType<TypeTextAnimations>();
        dialogueUI = FindObjectOfType<DialogueUI>; 
    }

    void Start()
    {
        state = STATE.DISABLE;
        StartDialogue(); 
    }

    void Update()
    {
        if (state == STATE.DISABLE) return;

        switch (state)
        {
            case STATE.WAITING:
                Waiting();
                break;
            case STATE.TYPING:
                Typing();
                break;
        }
    }

    public void StartDialogue()
    {
        if (dialogueData != null && dialogueData.talkScript.Count > 0)
        {
            state = STATE.WAITING;
            Next();
        }
        else
        {
            Debug.LogError("Não há dados de diálogo ou o script de diálogo está vazio.");
        }
    }

    public void Next()
    {
        if (finished) return;

        if (currentText < dialogueData.talkScript.Count)
        {
            typeText.fullText = dialogueData.talkScript[currentText].text;
            currentText++;

            if (currentText == dialogueData.talkScript.Count) finished = true;

            typeText.StartTyping();
            state = STATE.TYPING;
        }
    }

    void Waiting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Next();
        }
    }

    void Typing()
    {
        if (typeText.IsTypingComplete())
        {
            state = STATE.WAITING;
        }
    }
}
