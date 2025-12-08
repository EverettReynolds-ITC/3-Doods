using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    [SerializeField] private float normalBulletSpeed = 30f;
    [SerializeField] private float destroyTime = 3f;
    private Rigidbody2D rb;
    private bool canRot = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        SetDestroyTime();

        SetStraightVelocity();
    }
    private void FixedUpdate()
    {
        if (canRot)
        {
            transform.right = rb.linearVelocity;
        }
    }

    private void SetStraightVelocity()
    {
        rb.linearVelocity = transform.right * normalBulletSpeed;
    }

    private void SetDestroyTime()
    {
        Destroy(gameObject, destroyTime);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        canRot = false;
    }
}
