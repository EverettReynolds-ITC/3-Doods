using UnityEngine;

public class WizRangeChecker : MonoBehaviour
{
    private Animator anim;

    [SerializeField] private GameObject hitBox;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other1)
    {
        if (other1.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("InRange");
            activate();
        }
    }
    private void activate()
    {
        hitBox.SetActive(true);
    }
}
