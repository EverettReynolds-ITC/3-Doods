using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class killBird : MonoBehaviour
{
    public GameObject DefeatUI;
    void OnTriggerEnter2D(Collider2D other)
    {
        if( other.gameObject.tag == "Player" )
        {
            DefeatUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title Screen");
    }
}
