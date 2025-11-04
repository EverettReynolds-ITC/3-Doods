using UnityEngine;

public class flap : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody2D rb;
    public int flapi;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            flapp();
        }
    }
    public void flapp()
    {
        rb.linearVelocity = Vector2.up * flapi;
    }
}
