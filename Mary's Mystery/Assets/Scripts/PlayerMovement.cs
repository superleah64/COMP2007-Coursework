using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, 0.0f, z);

        transform.position += move;
    }
}
