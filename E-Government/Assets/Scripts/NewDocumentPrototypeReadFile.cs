using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewDocumentPrototypeReadFile : MonoBehaviour
{

    int id = 0;
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
        SceneDataManager.DocumentToSpawnInExecFolder.Add(id);

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

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInRecycleBin.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInRecycleBin[i] == id)
            {
                SceneDataManager.DocumentToSpawnInRecycleBin.Remove(i);
            }
        }

        SceneManager.LoadScene("FolderExec");
    }

    public void SendToLegisFolder()
    {
        SceneDataManager.DocumentToSpawnInLegisFolder.Add(id);

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
                SceneDataManager.DocumentToSpawnInJudiFolder.Remove(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInRecycleBin.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInRecycleBin[i] == id)
            {
                SceneDataManager.DocumentToSpawnInRecycleBin.Remove(i);
            }
        }

        SceneManager.LoadScene("FolderLegis");
    }

    public void SendToJudiFolder()
    {
        SceneDataManager.DocumentToSpawnInJudiFolder.Add(id);

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInExecFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInExecFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInExecFolder.Remove(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInLegisFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInLegisFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInLegisFolder.Remove(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInRecycleBin.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInRecycleBin[i] == id)
            {
                SceneDataManager.DocumentToSpawnInRecycleBin.Remove(i);
            }
        }

        SceneManager.LoadScene("FolderJudi");
    }

    public void SendToRecycleBin()
    {
        SceneDataManager.DocumentToSpawnInRecycleBin.Add(id);

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInExecFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInExecFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInExecFolder.Remove(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInLegisFolder.Count; i++)
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

        SceneManager.LoadScene("RecycleBin");
    }
}
