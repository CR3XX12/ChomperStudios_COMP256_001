using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    public void ResetToGame()
    {
        SceneManager.LoadScene("CrawlerZombies"); // Use your exact scene name here
    }
}

