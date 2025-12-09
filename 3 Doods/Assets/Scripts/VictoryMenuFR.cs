using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenuFR : MonoBehaviour
{
    public GameObject victoryUI;
    public string nextLevelName;
    private StreamWriter streamWriter;
    private bool activated = false;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("hitbox") && !activated)
        {
            activated = true;
            streamWriter = File.AppendText("CompletedLevels.txt");
            streamWriter.WriteLine("lvl3");
            streamWriter.Close();
            Invoke("ShowVictoryScreen", 4f);
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
