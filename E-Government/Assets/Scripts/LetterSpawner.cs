using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawner : MonoBehaviour
{
    static int LetterCount = 4;
    public Transform[] Spawns;
    public GameObject[] Letter;

    private void Start()
    {
        spawnLetters(1, 1);
    }

    public void spawnLetters(int day, int id)
    {
        if(day == 1)
        {
            if(id == 1)
            {
                for(int i = 0; i < LetterCount; i++)
                {
                    Instantiate(Letter[0], Spawns[i].position, Quaternion.identity);
                }
            }
        }
    }
}
