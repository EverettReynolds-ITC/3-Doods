using UnityEngine;
using UnityEngine.SceneManagement;

public class FallReset : MonoBehaviour
{
    [SerializeField] private float fallThreshold = -75f;

    void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            // Reload the current scene
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }
}