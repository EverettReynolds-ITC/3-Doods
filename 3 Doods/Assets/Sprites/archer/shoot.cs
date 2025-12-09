using Unity.VisualScripting;
using UnityEngine;

public class shoot : StateMachineBehaviour
{
    [SerializeField] private GameObject arrow;
    private float timer;
    public Transform shooted;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = 0f;
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer += Time.deltaTime;

        if (timer >= .75f)
        {
            GameObject newObject = Instantiate(arrow, animator.GetComponentInChildren<Transform>());
            Rigidbody2D rb = newObject.GetComponent<Rigidbody2D>();
            if (animator.transform.localScale.x < 0f)
            {
                newObject.transform.Rotate(0f, 180f, 0f);
            }
            rb.linearVelocity = newObject.transform.forward * 2f;
            timer = 0f;
        }
    }
}
