using UnityEngine;

public class animateonce : MonoBehaviour
{
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();

        // Play the animation from the start
        animator.Play(0, -1, 0f);

        // Get the animation clip length and schedule destruction
        float clipLength = animator.GetCurrentAnimatorStateInfo(0).length;
        Destroy(gameObject, clipLength);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
