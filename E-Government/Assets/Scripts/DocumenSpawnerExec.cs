using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocumenSpawnerExec : MonoBehaviour
{
    public Transform[] Spawns;
    public GameObject[] Document;

    private void Start()
    {
        spawnDocs();
    }


    //Checks if there is a document that needed to be spawned in the Executive folder and spawns those document/s based on the id
    private void spawnDocs()
    {
        if (SceneDataManager.DocumentToSpawnInExecFolder.Count > 0)
        {
            for (int i = 0; i < SceneDataManager.DocumentToSpawnInExecFolder.Count; i++)
            {
                Instantiate(Document[SceneDataManager.DocumentToSpawnInExecFolder[i]], Spawns[i].position, Quaternion.identity);
            }
        }
    }
}
