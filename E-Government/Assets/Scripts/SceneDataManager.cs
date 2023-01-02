using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDataManager : MonoBehaviour
{
    public static SceneDataManager Instance;

    public static int TotalScore = 0;
    public static int TodayScore = 0;

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
            }
        }
    }
}
