using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class LoadSaveSystem
{
    public static void Save(CurrencyManager currency)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath +  "/test.vbs";
        FileStream stream = new FileStream(path, FileMode.Create);

        SaveData data = new SaveData(currency);

        formatter.Serialize(stream, data);
        stream.Close();

    }
    public static SaveData Load()
    {
        string path = Application.persistentDataPath +  "/test.vbs";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            SaveData data = formatter.Deserialize(stream) as SaveData;
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
