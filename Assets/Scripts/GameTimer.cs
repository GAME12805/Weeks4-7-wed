using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Frog frog;
    public Slider timerVisuals;
    public float timerValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerValue = timerVisuals.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        timerValue -= Time.deltaTime;

        if(timerValue < 0)
        {
            frog.gameTimerIsRunning = false;
            frog.gameOverScreen.SetActive(true);
        }

        timerVisuals.value = timerValue;
    }
}
