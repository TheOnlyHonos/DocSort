using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ProgressData : MonoBehaviour
{
    public int day;
    public int debt;

    public ProgressData()
    {
        day = SceneDataManager.Day;
        debt = SceneDataManager.Debt;
    }
}
