using UnityEngine;
using UnityEngine.InputSystem.Android;
using UnityEngine.UI;

public class EnemyLife : MonoBehaviour
{
    [SerializeField] public int life;
    [SerializeField] public int lifeMax;
    public bool isDead;

    public MonoBehaviour victoryScript; 
    public string victoryMethodName = "WinScreen";
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checklife();

        if (life <= 0 && !isDead)
        {
            isDead = true;
            gameObject.SetActive(false);

            // Chama o método do script de vitória
            if (victoryScript != null)
            {
                victoryScript.Invoke(victoryMethodName, 0f);
            }

            Debug.Log("Enemy defeated. Victory screen activated.");
        }
    }

    void checklife()
    {
        if (life > lifeMax)
        {
            life = lifeMax;
        }

        if (life < 0)
        {
            life = 0;
        }
    }
}
