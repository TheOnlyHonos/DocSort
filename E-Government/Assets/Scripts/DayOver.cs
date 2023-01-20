using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DayOver : MonoBehaviour
{

    public TextMeshProUGUI Score;
    public TextMeshProUGUI Goal;
    public TextMeshProUGUI DebtStatus;

    public static int goal;

    void Start()
    {
        SetText();
    }

    private void SetText()
    {
        Score.text = "Today's income = " + SceneDataManager.TodayIncome;
        Goal.text = "Today's spending = " + goal;
        if(SceneDataManager.Debt > 0)
        {
            DebtStatus.text = "You are " + SceneDataManager.Debt + " days in debt.\n" +
                "You can't be in debt for two days in a row.";
        } else
        {
            DebtStatus.text = "You are not in debt right now.";
        }
    }

    public void GoToDesktop()
    {
        SceneDataManager.TodayIncome = 0;
        SceneDataManager.Day++;
        SceneManager.LoadScene("Desktop");
    }
}
