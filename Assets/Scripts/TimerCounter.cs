using UnityEngine.UI;
using UnityEngine;

public class TimerCounter : MonoBehaviour
{
    public Text timerText;
    private float secondsCount;
    private int minuteCount;
    void Update()
    {
        UpdateTimerUI();
    }
    //call this on update
    public void UpdateTimerUI()
    {
        //set timer UI
        secondsCount += Time.deltaTime;
        timerText.text = minuteCount.ToString("00") + ":" + ((int)secondsCount).ToString("00");
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            FindObjectOfType<GameManager>().endGame();
        }
    }
}
