using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private Vector2 direction;
    public InputActionReference action;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
    }

    private void Jump(InputAction.CallbackContext context)
    {
        Debug.Log("jump");
        rb.AddForce( new Vector2 (0, 1) );
    }

}
