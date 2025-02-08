using UnityEngine;

public class PaddleColision : MonoBehaviour
{
    public float minX; 
    public float maxX;  

    void Start()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, minX, maxX));
    }

    private void Update()
    {
        
    }

}