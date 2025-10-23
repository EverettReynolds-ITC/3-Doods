using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public BirdScript bird;
    public AudioSource ding;
    [ContextMenu("Increase Score")]
    private void Start()
    {
        HideCursor();
        Time.timeScale = 0f;
    }
    public void addScore(int scoreToAdd)
    {
        
        if (bird.birdIsAlive)
        {
            ding.Play();
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
        }
        
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        ShowCursor();
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("Title Screen");
    }
    public void ShowCursor()
    {
        Cursor.visible = true;
    }

    // Example: Call this method to hide the cursor
    public void HideCursor()
    {
        Cursor.visible = false;
    }
}
