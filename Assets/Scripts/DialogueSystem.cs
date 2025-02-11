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

    STATE state;

    void Awake()
    {
        typeText = Object.FindFirstObjectByType<TypeTextAnimations>();
    }

    void Start()
    {
        state = STATE.DISABLE;
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

    public void Next()
    {
        typeText.fullText = dialogueData.talkScript[currentText++].text;

        if (currentText == dialogueData.talkScript.Count) finished = true;

        typeText.StartTyping();
        state = STATE.TYPING;
    }

    void Waiting()
    {

    }

    void Typing()
    {

    }

}
