using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToScene : MonoBehaviour
{
    public void nextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void nextSceneFromGameOver()
    {
        SceneDataManager.TodayIncome = 0;
        SceneDataManager.Day = 0;
        SceneDataManager.TimeLeft = 600;
        SceneDataManager.IsTimerOn = true;
        SceneManager.LoadScene("Desktop");
    }

    public void exitGame()
    {
        SaveData();
        Application.Quit();
    }

    //save data
    public void SaveData()
    {
        SaveSystem.SaveProgress();
    }
}
