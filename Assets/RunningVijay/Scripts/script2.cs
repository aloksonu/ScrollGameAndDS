using UnityEngine;

public class script2 : MonoBehaviour
{
    float jumpForce;
    private Rigidbody2D rd2d;

    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
        jumpForce = 15f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Jump();
        }
    }

    void Jump()
    {
        rd2d.linearVelocity = Vector2.up * jumpForce;
    }


}
