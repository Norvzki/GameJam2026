using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 30f;
    public bool isRunning = false;
    public TMP_Text timerText;
    void Update()
    {
        if (!isRunning) return;

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerDisplay(timeRemaining);
        }
        else
        {
            timeRemaining = 0;
            isRunning = false;
        }
    }

    public bool IsTimerActive()
    {
        return isRunning && timeRemaining > 0;
    }

    public void StartTimer()
    {
        UpdateTimerDisplay(timeRemaining);
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }
    void UpdateTimerDisplay(float time)
    {
        int seconds = Mathf.CeilToInt(time);
        timerText.text = seconds.ToString();
    }
}
