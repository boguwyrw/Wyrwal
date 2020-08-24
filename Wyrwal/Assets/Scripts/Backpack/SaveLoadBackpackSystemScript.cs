using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoadBackpackSystemScript
{
    public static void SaveBackpackItem(BackpackScript backpackScript)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream fileStream = new FileStream(PathForFile(), FileMode.Create);

        BackpackDataScript backpackDataScript = new BackpackDataScript(backpackScript);

        binaryFormatter.Serialize(fileStream, backpackDataScript);
        fileStream.Close();
    }

    public static BackpackDataScript LoadBackpackItem()
    {
        if (File.Exists(PathForFile()))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(PathForFile(), FileMode.Open);

            BackpackDataScript backpackDataScript = binaryFormatter.Deserialize(fileStream) as BackpackDataScript;
            fileStream.Close();

            return backpackDataScript;
        }
        else
        {
            Debug.LogError("File not found");
            return null;
        }
    }

    private static string PathForFile()
    {
        string filePath = Application.persistentDataPath + "/backpack";
        return filePath;
    }
}
