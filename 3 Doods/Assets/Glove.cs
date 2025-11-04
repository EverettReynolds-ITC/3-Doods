using UnityEngine;
using UnityEngine.SceneManagement;

public class Glove : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("ArcherLevel");
    }
}
