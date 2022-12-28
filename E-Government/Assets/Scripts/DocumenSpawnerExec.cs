using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocumenSpawnerExec : MonoBehaviour
{
    public Transform[] Spawns;
    public GameObject[] Document;

    private void Start()
    {
        spawnLetters(1, 1);
    }

    public void spawnLetters(int day, int id)
    {
        if (day == 1)
        {
            if (id == 1)
            {
                if (SceneDataManager.DocumentToSpawnInExecFolder.Count > 0)
                {
                    for (int i = 0; i < SceneDataManager.DocumentToSpawnInExecFolder.Count; i++)
                    {
                        Instantiate(Document[0], Spawns[i].position, Quaternion.identity);
                    }
                }
            }
        }
    }
}
