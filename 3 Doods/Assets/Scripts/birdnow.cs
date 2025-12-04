using UnityEngine;
using UnityEngine.SceneManagement;

public class birdnow : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("ArcherLevel");
        }
    }
}
