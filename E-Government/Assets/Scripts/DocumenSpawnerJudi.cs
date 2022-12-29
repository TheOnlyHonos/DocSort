using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocumenSpawnerJudi : MonoBehaviour
{
    public Transform[] Spawns;
    public GameObject[] Document;

    private void Start()
    {
        spawnDocs();
    }

    private void spawnDocs()
    {
        if (SceneDataManager.DocumentToSpawnInJudiFolder.Count > 0)
        {
            for (int i = 0; i < SceneDataManager.DocumentToSpawnInJudiFolder.Count; i++)
            {
                Instantiate(Document[SceneDataManager.DocumentToSpawnInJudiFolder[i]], Spawns[i].position, Quaternion.identity);
            }
        }
    }
}
