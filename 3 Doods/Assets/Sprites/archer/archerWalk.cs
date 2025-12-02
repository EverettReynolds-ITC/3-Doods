using UnityEngine;

public class archerWalk : StateMachineBehaviour
{
    private GameObject target;
    private Rigidbody2D rb;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        target = GameObject.FindWithTag("Player");
        rb = animator.GetComponent<Rigidbody2D>();
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(animator.transform.position.x > target.transform.position.x)
        {
            animator.transform.localScale = new Vector3(Mathf.Abs(animator.transform.localScale.x) * -1f, animator.transform.localScale.y, animator.transform.localScale.z);
            rb.linearVelocityX = -3f;
        }
        else
        {
            animator.transform.localScale = new Vector3(Mathf.Abs(animator.transform.localScale.x), animator.transform.localScale.y, animator.transform.localScale.z);
            rb.linearVelocityX = 3f;
        }

    }
}
