using UnityEngine;
using UnityEngine.SceneManagement;

public class hit : MonoBehaviour
{
    public Player player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Healthbar").GetComponent<Player>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.TakeDamage();
        }
    }
}
