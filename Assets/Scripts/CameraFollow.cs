using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 5.0f; 
    public Vector3 offset = new Vector3(25, 5, -50); 

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("Target not assigned in CameraFollow script.");
            return;
        }

        
        Vector3 desiredPosition = target.position + offset;

      
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        
        transform.position = smoothedPosition;
    }
}
