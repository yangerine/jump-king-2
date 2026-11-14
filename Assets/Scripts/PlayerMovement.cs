using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float multiplier;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private PlayerInput playerInput;

    private float direction;
    private bool canJump = true;

    private float pressStartTime;
    private float holdDuration;

    private void Start()
    {

    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2 (direction * speed, rb.linearVelocity.y);
    }

    public void Jump(InputAction.CallbackContext context)
    {

        if (context.performed && IsGrounded() )
        {
            pressStartTime = (float)context.startTime;

            Debug.Log("press start time: " + pressStartTime);
            //Debug.Log("hold");
        }
        else if (context.canceled && IsGrounded() ) 
        {
            holdDuration = (float)context.time - pressStartTime;
            Debug.Log("held duration: " + holdDuration);

            float multiplier = Mathf.Clamp(holdDuration, 1f, 1.8f);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce * multiplier);
            Debug.Log("long jump");

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
