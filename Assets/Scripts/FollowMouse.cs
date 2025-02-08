using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public Camera mainCamera;
    //public float minX;
    //public float maxX;


    void Update()
    {
        //transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.x, minX, maxX));
    
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = mainCamera.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 0f)); 

        transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z);
    }
}
