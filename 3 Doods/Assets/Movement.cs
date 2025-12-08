using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjustable movement speed in the Inspector
    private Rigidbody2D rb;
    private Vector2 movementInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component attached to this GameObject
    }

    void Update()
    {
        // Get horizontal and vertical input from the player (e.g., WASD or Arrow Keys)
        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");

        // Normalize the movement vector to prevent faster diagonal movement
        movementInput.Normalize(); 
    }

    void FixedUpdate()
    {
        // Apply velocity to the Rigidbody2D for movement
        rb.linearVelocity = movementInput * moveSpeed;
    }
}