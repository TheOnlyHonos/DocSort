using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public float TimeLeft;
    public bool IsTimerOn = true;
    public TextMeshProUGUI TimerTxt;

    void Start()
    {
        TimeLeft = SceneDataManager.TimeLeft;

        updateTimer(TimeLeft);
    }

    // Update is called once per frame
    void Update()
    {
        TimeLeft = SceneDataManager.TimeLeft;
        if (IsTimerOn == true)
        {
            updateTimer(TimeLeft);
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minute = Mathf.FloorToInt(currentTime / 60);
        float second = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00}", minute, second);
    }
}
