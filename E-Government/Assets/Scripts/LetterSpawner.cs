using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawner : MonoBehaviour
{
    static int LetterCount = 8;
    public Transform[] Spawns;
    public GameObject[] Letter;

    private void Start()
    {
        spawnLetters(SceneDataManager.Day, 1);
    }

    public void spawnLetters(int day, int id)
    {
        if(day == 0)
        {
            for(int i = 0; i < LetterCount; i++)
            {
                Instantiate(Letter[0], Spawns[i].position, Quaternion.identity);
            }
        }

        if (day == 1)
        {
            for (int i = 7; i < LetterCount + 8; i++)
            {
                Instantiate(Letter[0], Spawns[i].position, Quaternion.identity);
            }
        }

        if (day == 2)
        {
            for (int i = 15; i < LetterCount + 16; i++)
            {
                Instantiate(Letter[0], Spawns[i].position, Quaternion.identity);
            }
        }
    }
}
