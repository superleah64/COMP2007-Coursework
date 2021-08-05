using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    // run after update so there is no interference with other update methods
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
