using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Unity.Collections;

public class TimerObject : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timeRemaining = 310.0f;
    private bool isTimerRunning;

    void Start()
    {
        isTimerRunning = true;
    }

    void Update()
    {
        if (timeRemaining > 0 && isTimerRunning == true)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        else
        {
            // TODO: Add instantiate panel prefab coroutine
            isTimerRunning = false;
            timeRemaining = 0;
            DisplayTime(0.001f);
        }
    }

    void DisplayTime (float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
