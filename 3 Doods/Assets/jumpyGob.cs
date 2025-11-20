using UnityEngine;

public class jumpyGob : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Rigidbody2D rb;
    
    private void OnTriggerEnter(Collider collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            rb.linearVelocityY = 5f;
        }
    }

}
