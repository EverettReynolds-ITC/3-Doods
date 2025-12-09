using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryTrigger : MonoBehaviour
{
    public GameObject victoryUI;
    public string nextLevelName;
    [SerializeField] private flap flapref;
    private StreamWriter streamWriter;

    private bool activated = false;
    private void OnTriggerEnter2D(Collider2D other)
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
        if (flapref.gold)
        {
            streamWriter = File.AppendText("CompletedLevels.txt");
            streamWriter.WriteLine("lvl2");
            streamWriter.WriteLine("lvl3");
            streamWriter.WriteLine("lvl3G");
            streamWriter.Close();
        }
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