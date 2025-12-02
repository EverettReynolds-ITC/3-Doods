using UnityEngine;

public class fly : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform parent; 
    private Vector3 position;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        parent = GameObject.FindGameObjectWithTag("Enemy").transform;
        position = GameObject.FindGameObjectWithTag("arrowSpawn").transform.position;
        transform.position = position;
        if (parent.localScale.x > 0)
        {
            transform.localScale = new Vector3(4f, 4, 4);
            rb.linearVelocityX = 20f;
        }
        else
        {
            transform.localScale = new Vector3(-4f, 4, 4);
            rb.linearVelocityX = -20f;
        }
        Destroy(gameObject, 10f);
    }
}
