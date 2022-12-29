using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocumenSpawnerRecycleBin : MonoBehaviour
{
    public Transform[] Spawns;
    public GameObject[] Document;

    private void Start()
    {
        spawnDocs();
    }

    private void spawnDocs()
    {
        if (SceneDataManager.DocumentToSpawnInRecycleBin.Count > 0)
        {
            for (int i = 0; i < SceneDataManager.DocumentToSpawnInRecycleBin.Count; i++)
            {
                Instantiate(Document[SceneDataManager.DocumentToSpawnInRecycleBin[i]], Spawns[i].position, Quaternion.identity);
            }
        }
    }
}
