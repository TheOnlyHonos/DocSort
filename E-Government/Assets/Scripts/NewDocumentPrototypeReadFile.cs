using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewDocumentPrototypeReadFile : MonoBehaviour
{
    //Variable to hold Document id
    public int id;

    //Button in the scene to send the document to the Executive folder and delete the document from other folders
    public void SendToExecFolder()
    {

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInExecFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInExecFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInExecFolder.RemoveAt(i);
            }
        }
        
        for (int i = 0; i < SceneDataManager.DocumentToSpawnInLegisFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInLegisFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInLegisFolder.RemoveAt(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInJudiFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInJudiFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInJudiFolder.RemoveAt(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInRecycleBin.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInRecycleBin[i] == id)
            {
                SceneDataManager.DocumentToSpawnInRecycleBin.RemoveAt(i);
            }
        }

        SceneDataManager.DocumentToSpawnInExecFolder.Add(id);
        SceneManager.LoadScene("FolderExec");
    }

    //Button in the scene to send the document to the Legislative folder and delete the document from other folders
    public void SendToLegisFolder()
    {

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInExecFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInExecFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInExecFolder.RemoveAt(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInLegisFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInLegisFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInLegisFolder.RemoveAt(i);
            }
        }
        
        for (int i = 0; i < SceneDataManager.DocumentToSpawnInJudiFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInJudiFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInJudiFolder.RemoveAt(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInRecycleBin.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInRecycleBin[i] == id)
            {
                SceneDataManager.DocumentToSpawnInRecycleBin.RemoveAt(i);
            }
        }

        SceneDataManager.DocumentToSpawnInLegisFolder.Add(id);
        SceneManager.LoadScene("FolderLegis");
    }

    //Button in the scene to send the document to the Judicial folder and delete the document from other folders
    public void SendToJudiFolder()
    {

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInExecFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInExecFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInExecFolder.RemoveAt(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInLegisFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInLegisFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInLegisFolder.RemoveAt(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInJudiFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInJudiFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInJudiFolder.RemoveAt(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInRecycleBin.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInRecycleBin[i] == id)
            {
                SceneDataManager.DocumentToSpawnInRecycleBin.RemoveAt(i);
            }
        }

        SceneDataManager.DocumentToSpawnInJudiFolder.Add(id);
        SceneManager.LoadScene("FolderJudi");
    }

    //Button in the scene to send the document to the Recycle Bin and delete the document from other folders
    public void SendToRecycleBin()
    {

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInExecFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInExecFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInExecFolder.RemoveAt(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInLegisFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInLegisFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInLegisFolder.RemoveAt(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInJudiFolder.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInJudiFolder[i] == id)
            {
                SceneDataManager.DocumentToSpawnInJudiFolder.RemoveAt(i);
            }
        }

        for (int i = 0; i < SceneDataManager.DocumentToSpawnInRecycleBin.Count; i++)
        {
            if (SceneDataManager.DocumentToSpawnInRecycleBin[i] == id)
            {
                SceneDataManager.DocumentToSpawnInRecycleBin.RemoveAt(i);
            }
        }

        SceneDataManager.DocumentToSpawnInRecycleBin.Add(id);
        SceneManager.LoadScene("RecycleBin");
    }
}
