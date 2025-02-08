using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float velocidadeDaBola;

    public Rigidbody2D oRigidbody2D;

    void Start()
    {
        MoverBola();
    }
    private void MoverBola()
    {
        oRigidbody2D.linearVelocity = new Vector2(velocidadeDaBola, velocidadeDaBola);
    }
}
