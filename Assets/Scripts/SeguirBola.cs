using UnityEngine;

public class SeguirBola : MonoBehaviour
{
    public Transform target;
    public float followSpeed = 5f;

    void Update()
    {
        if (target != null)
        {
            Vector3 currentPosition = transform.position;

            Vector3 targetPosition = new Vector3(target.position.x, currentPosition.y, currentPosition.z);

            transform.position = Vector3.Lerp(currentPosition, targetPosition, followSpeed * Time.deltaTime);
        }
        else
        {
            Debug.LogWarning("O alvo não foi atribuído ao objeto seguidor!");
        }
    }
}