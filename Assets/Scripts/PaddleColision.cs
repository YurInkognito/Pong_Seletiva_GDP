using UnityEngine;

public class PaddleColision : MonoBehaviour
{
    public float minX; 
    public float maxX;  

    private void Colision()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.x, minX, maxX));
    }
   
}