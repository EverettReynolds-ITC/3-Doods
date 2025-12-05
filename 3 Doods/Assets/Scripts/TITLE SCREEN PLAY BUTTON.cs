using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TITLESCREENPLAYBUTTON : MonoBehaviour
{
    public GameObject creditsYo;
    public GameObject titleScreen;

    public GameObject levelSelectYo;
    public void startGame()
    {
        titleScreen.SetActive(false);
        levelSelectYo.SetActive(true);
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
    public void level1()
    {
        SceneManager.LoadScene("ArcherLevel");
    }

    public void level2()
    {
        SceneManager.LoadScene("KnightLevel");
    }

    public void level3()
    {
        SceneManager.LoadScene("BirdLevel");
    }

    public void selectToMain()
    {
        levelSelectYo.SetActive(false);
        titleScreen.SetActive(true);
    }
}
