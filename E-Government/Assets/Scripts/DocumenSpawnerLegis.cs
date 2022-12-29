using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocumenSpawnerLegis : MonoBehaviour
{
    public Transform[] Spawns;
    public GameObject[] Document;

    private void Start()
    {
        spawnDocs();
    }

    private void spawnDocs()
    {
        if (SceneDataManager.DocumentToSpawnInLegisFolder.Count > 0)
        {
            for (int i = 0; i < SceneDataManager.DocumentToSpawnInLegisFolder.Count; i++)
            {
                Instantiate(Document[SceneDataManager.DocumentToSpawnInLegisFolder[i]], Spawns[i].position, Quaternion.identity);
            }
        }
    }
}
