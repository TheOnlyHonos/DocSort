using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawner : MonoBehaviour
{
    public Transform[] Spawns;
    public GameObject[] Letter;

    private void Start()
    {
        spawnLetters(SceneDataManager.Day);
    }

    public void spawnLetters(int day)
    {
        if(day == 0)
        {
            for(int i = 0; i < 6; i++)
            {
                Instantiate(Letter[i + 1], Spawns[i].position, Quaternion.identity);
            }
        }

        if (day == 1)
        {
            for (int i = 0; i < 6; i++)
            {
                Instantiate(Letter[i + 7], Spawns[i].position, Quaternion.identity);
            }
        }

        if (day == 2)
        {
            for (int i = 0; i < 7; i++)
            {
                Instantiate(Letter[i + 13], Spawns[i].position, Quaternion.identity);
            }
        }
    }
}
