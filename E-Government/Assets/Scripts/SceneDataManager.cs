using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDataManager : MonoBehaviour
{
    public static SceneDataManager Instance;

    public static int Day = 0;

    public static int TotalScore = 0;
    public static int TodayIncome = 0;

    public int[] Goal = { 100, 200, 300 };
    public static int Debt = 0;

    //Lists to hold the amount of documents to spawn in each folder with the document id as the value
    public static List<int> DocumentToSpawnInExecFolder = new List<int>();
    public static List<int> DocumentToSpawnInLegisFolder = new List<int>();
    public static List<int> DocumentToSpawnInJudiFolder = new List<int>();
    public static List<int> DocumentToSpawnInRecycleBin = new List<int>();

    //Variable for timer per day
    public static float TimeLeft = 600;
    public static bool IsTimerOn = true;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Update()
    {
        if (Day == 3)
        {
            //end game here ending
        }

        //Count the timer
        if (IsTimerOn == true)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
            }
            else
            {
                TimeLeft = 0;
                IsTimerOn = false;
                CheckIncomeAndScoreDayTemplate();

                if(Debt > 1)
                {
                    SceneManager.LoadScene("GameOver");
                    Day = 0;
                    Debt = 0;
                }

                DocumentToSpawnInExecFolder.Clear();
                DocumentToSpawnInLegisFolder.Clear();
                DocumentToSpawnInJudiFolder.Clear();
                DocumentToSpawnInRecycleBin.Clear();
            }
        }
    }

    private void CheckIncomeAndScoreDayTemplate()
    {
        if(Day == 0)
        {
            //check if a document with the id 0 is in exec folder and add money
            for (int i = 0; i < DocumentToSpawnInExecFolder.Count; i++)
            {
                if (DocumentToSpawnInExecFolder[i] == 0)
                {
                    TodayIncome += 100;
                }
            }

            if (TodayIncome < Goal[0])
            {
                Debt++;
            }

            DayOver.goal = Goal[0];
            SceneManager.LoadScene("DayOver");
        }
        Debug.Log("Income : " + TodayIncome + "\nDebt : " + Debt);
    }


    //Save and load
    public void SaveData()
    {
        SaveSystem.SaveProgress();
    }

    public void LoadData()
    {
        ProgressData data = SaveSystem.LoadProgress();

        Day = data.day;
        Debt = data.debt;
    }

}
