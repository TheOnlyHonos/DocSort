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

    //Checks if there is a document that needed to be spawned in the Judicial folder and spawns those document/s based on the id
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
