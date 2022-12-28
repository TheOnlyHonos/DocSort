using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewDocumentPrototypeReadFile : MonoBehaviour
{

    int id;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SendToExecFolder()
    {
        SceneDataManager.DocumentToSpawnInExecFolder.Add(0);

        for(int i = 0; i < SceneDataManager.DocumentToSpawnInLegisFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInLegisFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInLegisFolder.Remove(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInJudiFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInJudiFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInJudiFolder.Remove(i);
            }
        }

        SceneManager.LoadScene("Mail");
    }

    public void SendToLegisFolder()
    {
        SceneDataManager.DocumentToSpawnInLegisFolder.Add(0);

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInExecFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInExecFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInExecFolder.Remove(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInJudiFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInJudiFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInJudiFolder.Remove(i-1);
            }
        }

        SceneManager.LoadScene("Mail");
    }

    public void SendToJudiFolder()
    {
        SceneDataManager.DocumentToSpawnInJudiFolder.Add(0);

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInLegisFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInLegisFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInLegisFolder.Remove(i-1);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInExecFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInExecFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInExecFolder.Remove(i-1);
            }
        }

        SceneManager.LoadScene("Mail");
    }
}
