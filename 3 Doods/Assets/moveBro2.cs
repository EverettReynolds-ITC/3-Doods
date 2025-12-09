using UnityEngine;

public class moveBro2 : MonoBehaviour
{
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocityX = -2;
    }
}
