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

    //Checks if there is a document that needed to be spawned in the Legislative folder and spawns those document/s based on the id
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
