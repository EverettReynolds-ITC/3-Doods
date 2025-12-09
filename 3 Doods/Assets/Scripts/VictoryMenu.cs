using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryTrigger : MonoBehaviour
{
    public GameObject victoryUI;
    public string nextLevelName;

    private bool activated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !activated)
        {
            activated = true;
            ShowVictoryScreen();
        }
    }

    void ShowVictoryScreen()
    {
        victoryUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoadNextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(nextLevelName);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title Screen");
    }
}