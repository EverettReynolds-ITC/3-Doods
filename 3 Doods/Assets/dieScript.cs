using Unity.VisualScripting;
using UnityEngine;

public class dieScript : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("hitbox"))
        {
            anim.SetTrigger("die");
        }
    }
}
