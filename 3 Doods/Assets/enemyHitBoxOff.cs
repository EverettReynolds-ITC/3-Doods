using UnityEngine;

public class enemyHitBoxOff : StateMachineBehaviour
{
    private GameObject hitbox;
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        hitbox = GameObject.FindGameObjectWithTag("enemyHitbox");
        hitbox.SetActive(false);
    }
}
