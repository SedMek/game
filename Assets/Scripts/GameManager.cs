using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    float restartDelay = 2;
    // public GameObject levelCompletePanel;
    // public score scoreText;
    public void endGame()
    {
        if (!gameHasEnded)
        {
            Debug.Log("You lose");
            gameHasEnded = true;
            // scoreText.enabled = false;
            Invoke("restart", restartDelay);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // public void completeLevel()
    // {
    //     if (!gameHasEnded)
    //     {
    //         levelCompletePanel.SetActive(true);
    //         scoreText.enabled = false;
    //         gameHasEnded = true;
    //     }
    // }
}
