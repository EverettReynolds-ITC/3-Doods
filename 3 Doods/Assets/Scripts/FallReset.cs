using UnityEngine;
using UnityEngine.SceneManagement;

public class FallReset : MonoBehaviour
{
    [SerializeField] private float fallThreshold = -75f;

    public GameObject DefeatUI;

    public Player health;

    void Update()
    {
        if (transform.position.y < fallThreshold || health.currentHealth <= 0)
        {
            ShowDefeatScreen();
        }
    }

    void ShowDefeatScreen()
    {
        DefeatUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartLevel()
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