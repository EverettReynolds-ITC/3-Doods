using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public GameObject deathUI;
    private bool isDead = false;

    public void PlayerDied()
    {
        if (isDead) return;

        isDead = true;
        deathUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title Screen");
    }
}