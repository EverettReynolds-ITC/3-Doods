using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CastleScript : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("hitbox"))
        {
            anim.SetBool("hit", true);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("hitbox"))
        {
            anim.SetBool("hit", true);
        }
    } 
}
