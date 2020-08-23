using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    float restartDelay = 2;
    public GameObject levelCompletePanel;
    public TimerCounter TextTimer;
    public void endGame()
    {
        if (!gameHasEnded)
        {
            Debug.Log("You lose");
            gameHasEnded = true;
            TextTimer.enabled = false;
            Invoke("restart", restartDelay);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void completeLevel()
    {
        if (!gameHasEnded)
        {
            Debug.Log("Level Won");
            levelCompletePanel.SetActive(true);
            TextTimer.enabled = false;
            gameHasEnded = true;
        }
    }
}
