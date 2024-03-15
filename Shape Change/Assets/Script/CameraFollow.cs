using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target to follow
    public float smoothSpeed = 0.125f; // The speed at which the camera follows the target
    public Vector3 offset; // The offset of the camera from the target

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired position of the camera
            Vector3 desiredPosition = target.position + offset;
            // Smoothly move the camera towards the desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
