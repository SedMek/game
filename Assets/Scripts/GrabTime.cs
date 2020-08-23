using UnityEngine.UI;
using UnityEngine;

public class GrabTime : MonoBehaviour
{

    public Text TextTimer;

    public Text time;

    public void Update()
    {
        time.text = TextTimer.text;
    }
}
