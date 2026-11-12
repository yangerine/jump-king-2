using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float multiplier = 0.5f;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private PlayerInput playerInput;

    private float currentTime;
    private float maxtime = 3;
    private float direction;

    private void Start()
    {

    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2 (direction * speed, rb.linearVelocity.y);

    }

    public void Jump(InputAction.CallbackContext context)
    {

        if(context.performed && IsGrounded() )
        {
            jumpForce *= Time.deltaTime;
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            Debug.Log("jump");
        }

        
    }

    public void Move(InputAction.CallbackContext context)
    {
        //bien nay doc duoc value cua input khi an nut di chuyen duoc gan trong input action
        //tra lai gia tri float tu -1 den 1
        direction = context.ReadValue<Vector2>().x;
    }  

    //isGrounded prevent infinite jumping and only jump once after the player touched the ground layer
    private bool IsGrounded()
    {
        return Physics2D.OverlapCapsule(groundCheck.position, new Vector2(1f, 0.1f), CapsuleDirection2D.Horizontal, 0, groundLayer);
    }

}
