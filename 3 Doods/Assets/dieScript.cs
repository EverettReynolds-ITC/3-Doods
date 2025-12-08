using Unity.VisualScripting;
using UnityEngine;

public class dieScript : MonoBehaviour
{
    private Animator anim;
    private PlayerAimAndShoot archerScript;
    private void Start()
    {
        anim = GetComponent<Animator>();
        archerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAimAndShoot>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("hitbox"))
        {
            anim.SetTrigger("die");
            Invoke("kill", 2.9f);
        }
        else if (!other.gameObject.CompareTag("Enemy") && Mathf.Abs(other.gameObject.GetComponent<Rigidbody2D>().angularVelocity)
            + Mathf.Abs(other.gameObject.GetComponent<Rigidbody2D>().linearVelocityX)
            + Mathf.Abs(other.gameObject.GetComponent<Rigidbody2D>().linearVelocityY) > 10f)
        {
            anim.SetTrigger("die");
            Invoke("kill", 2.9f);
        }
    }
    private void kill()
    {
        archerScript.enemyDepleter();
        Destroy(gameObject);
    }
}
