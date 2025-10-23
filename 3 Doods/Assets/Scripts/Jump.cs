using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public BirdScript bird;
    private bool isFirstJump = true;
    public GameObject instructions;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && bird.birdIsAlive)
        {
            if (isFirstJump)
            {
                Time.timeScale = 1f;
                isFirstJump = false;
                instructions.SetActive(false);
            }

            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
    }
}
