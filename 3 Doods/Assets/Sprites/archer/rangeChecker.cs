using UnityEngine;

public class rangeChecker : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other1)
    {
        if (other1.gameObject.CompareTag("Player"))
        {
            anim.SetBool("InRange", true);
        }
    }
    private void OnTriggerExit2D(Collider2D other2)
    {
        if (other2.gameObject.CompareTag("Player"))
        {
            anim.SetBool("InRange", false);
        }
    }
}
