using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveProgress()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/progress.save";

        FileStream stream = new FileStream(path, FileMode.Create);

        ProgressData data = new ProgressData();
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static ProgressData LoadProgress()
    {
        string path = Application.persistentDataPath + "/progress.save";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ProgressData data = formatter.Deserialize(stream) as ProgressData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found" + path);
            return null;
        }
    }
}
