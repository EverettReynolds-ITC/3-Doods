using UnityEngine;

public class movebro : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int moveF;
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector3.left * moveF);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
