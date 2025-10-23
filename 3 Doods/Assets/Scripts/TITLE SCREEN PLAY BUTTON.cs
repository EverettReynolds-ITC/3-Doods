using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TITLESCREENPLAYBUTTON : MonoBehaviour
{
    public GameObject creditsYo;
    public GameObject titleScreen;
    public void startGame()
    {
        SceneManager.LoadScene("knightlevel");
    }
    public void credits()
    {
        creditsYo.SetActive(true);
        titleScreen.SetActive(false);
    }
    public void mainMenu()
    {
        creditsYo.SetActive(false);
        titleScreen.SetActive(true);
    }
    public void quit()
    {
        Application.Quit();
    }
}
