using UnityEngine;

public class shoot : StateMachineBehaviour
{
    [SerializeField] private GameObject arrow;
    float timer;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = 0f;
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer += Time.deltaTime;

        if (timer >= .75f)
        {
            Instantiate(arrow);
            timer = 0f;
        }
    }
}
