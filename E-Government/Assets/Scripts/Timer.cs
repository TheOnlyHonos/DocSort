using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerTxt;

    void Start()
    {
        updateTimer(SceneDataManager.TimeLeft);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneDataManager.IsTimerOn == true)
        {
            updateTimer(SceneDataManager.TimeLeft);
        }
    }

    //Display the timeleft in minutes and seconds
    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minute = Mathf.FloorToInt(currentTime / 60);
        float second = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00}", minute, second);
    }
}
