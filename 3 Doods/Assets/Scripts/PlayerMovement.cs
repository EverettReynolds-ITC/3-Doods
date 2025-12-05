using UnityEngine;

public class SideScrollPlayerController : MonoBehaviour
{
    public float moveSpeed = 10.0f;

    public float jumpForce = 8.0f;

    Rigidbody2D rb;

    public bool isGrounded = false;

    public bool shouldJump = false;

    private Animator animator;

    private Vector3 originalScale;

    private float horizontalInput;

    [SerializeField] private GameObject killbox;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
{
    horizontalInput = Input.GetAxis("Horizontal");

    if (horizontalInput != 0f)
    {
        animator.SetBool("isRunning", true);

        // flip fix
        if (horizontalInput > 0f)
            transform.localScale = new Vector3(originalScale.x, originalScale.y, originalScale.z);
        else
            transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z);
    }
    else
    {
        animator.SetBool("isRunning", false);
    }

    if (Input.GetButtonDown("Jump") && isGrounded)
        shouldJump = true;

    if (Input.GetKeyDown(KeyCode.RightShift))
    {
        killbox.SetActive(true);
        animator.SetTrigger("slash");
    }
}

    void FixedUpdate()
{
    // horizontal movement using physics
    rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);

    if (shouldJump)
    {
        shouldJump = false;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("offGround", false);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            animator.SetBool("offGround", true);
        }
    }
}