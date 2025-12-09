using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class birdnow : MonoBehaviour
{
    public GameObject victoryUI;
    public string nextLevelName;
    private StreamWriter streamWriter;
    private bool activated = false;
    private GameObject checker = null;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && !activated)
        {
            checker = GameObject.FindGameObjectWithTag("Enemy");
            activated = true;
            streamWriter = File.AppendText("CompletedLevels.txt");
            streamWriter.WriteLine("lvl2");
            if (checker == null)
            {
                streamWriter.WriteLine("lvl1G");
            }
            streamWriter.Close();
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

