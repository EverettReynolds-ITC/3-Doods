using UnityEngine;
using UnityEngine.SceneManagement;

public class EpicFail : MonoBehaviour
{
    public Player player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Healthbar").GetComponent<Player>();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") 
        {

            // write something to the Console just to make 
            // sure this function is being called
            Debug.Log("What are you doing");
            player.TakeDamage();
        }
    }

}