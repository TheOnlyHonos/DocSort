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
        LoadData();
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
        if (Day > 2)
        {
            //Ending 1 (no debt and no bribe)
            if (Debt < 1 && TotalScore < 1){
                SceneManager.LoadScene("Ending 1");
                Destroy(gameObject);
            } 
            
            //Ending 2 (no bribe)
            else if (TotalScore < 1)
            {
                SceneManager.LoadScene("Ending 2");
                Destroy(gameObject);
            }

            //Ending 3 (took bribe)
            else if (TotalScore > 0)
            {
                SceneManager.LoadScene("Ending 3");
                Destroy(gameObject);
            }
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
                if (DocumentToSpawnInExecFolder[i] == 1 ||
                    DocumentToSpawnInExecFolder[i] == 3 ||
                    DocumentToSpawnInExecFolder[i] == 5)
                {
                    TodayIncome += 100;
                } 
            }

            for (int i = 0; i < DocumentToSpawnInLegisFolder.Count; i++)
            {
                if (DocumentToSpawnInLegisFolder[i] == 2)
                {
                    TodayIncome += 100;
                }
            }

            for (int i = 0; i < DocumentToSpawnInJudiFolder.Count; i++)
            {
                if (DocumentToSpawnInJudiFolder[i] == 4 ||
                    DocumentToSpawnInJudiFolder[i] == 6)
                {
                    TodayIncome += 100;
                }
            }

            if (TodayIncome < 300)
            {
                Debt++;
            }

            DayOver.goal = 300;
            SceneManager.LoadScene("DayOver");
        } 

        else if (Day == 1)
        {
            //check if a document with the id 0 is in exec folder and add money
            for (int i = 0; i < DocumentToSpawnInExecFolder.Count; i++)
            {
                if (DocumentToSpawnInExecFolder[i] == 7)
                {
                    TodayIncome += 100;
                }
            }

            for (int i = 0; i < DocumentToSpawnInLegisFolder.Count; i++)
            {
                if (DocumentToSpawnInLegisFolder[i] == 9)
                {
                    TodayIncome += 100;
                }
            }

            for (int i = 0; i < DocumentToSpawnInRecycleBin.Count; i++)
            {
                if (DocumentToSpawnInRecycleBin[i] == 8 ||
                    DocumentToSpawnInRecycleBin[i] == 10 ||
                    DocumentToSpawnInRecycleBin[i] == 11 ||
                    DocumentToSpawnInRecycleBin[i] == 12)
                {
                    TodayIncome += 100;
                }
            }

            if (TodayIncome < 400)
            {
                Debt++;
            }

            DayOver.goal = 400;
            SceneManager.LoadScene("DayOver");
        }

        else if (Day == 2)
        {
            //check if a document with the id 0 is in exec folder and add money
            for (int i = 0; i < DocumentToSpawnInLegisFolder.Count; i++)
            {
                if (DocumentToSpawnInLegisFolder[i] == 17)
                {
                    TodayIncome += 100;
                }

                if (DocumentToSpawnInLegisFolder[i] == 19)
                {
                    TodayIncome += 100;
                    TotalScore++;
                }
            }

            for (int i = 0; i < DocumentToSpawnInJudiFolder.Count; i++)
            {
                if (DocumentToSpawnInJudiFolder[i] == 18)
                {
                    TodayIncome += 100;
                }

                if (DocumentToSpawnInJudiFolder[i] == 15)
                {
                    TodayIncome += 100;
                    TotalScore++;
                }
            }

            for (int i = 0; i < DocumentToSpawnInRecycleBin.Count; i++)
            {
                if (DocumentToSpawnInRecycleBin[i] == 13 ||
                    DocumentToSpawnInRecycleBin[i] == 14 ||
                    DocumentToSpawnInRecycleBin[i] == 16)
                {
                    TodayIncome += 100;
                }
            }

            if (TodayIncome < 500)
            {
                Debt++;
            }

            DayOver.goal = 500;
            SceneManager.LoadScene("DayOver");
        }
    }


    //load save
    public void LoadData()
    {
        ProgressData data = SaveSystem.LoadProgress();

        Day = data.day;
        Debt = data.debt;
    }

}
