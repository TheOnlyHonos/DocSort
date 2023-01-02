using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewDocumentPrototypeReadFile : MonoBehaviour
{
    //Variable to hold Document id
    int id = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Button in the scene to send the document to the Executive folder and delete the document from other folders
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

    //Button in the scene to send the document to the Legislative folder and delete the document from other folders
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

    //Button in the scene to send the document to the Judicial folder and delete the document from other folders
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

    //Button in the scene to send the document to the Recycle Bin and delete the document from other folders
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
