using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public Camera mainCamera; 

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = mainCamera.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 0f)); 

        transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z);
    }
}
