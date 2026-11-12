using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;

    private float direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2 (direction * speed, rb.linearVelocity.y);
    }


    public void Move(InputAction.CallbackContext context)
    {
        //bien nay doc duoc value cua input khi an nut di chuyen duoc gan trong input action
        //tra lai gia tri float tu -1 den 1
        direction = context.ReadValue<Vector2>().x;
    }  

}
