using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoadMainDoorSystemScript
{
    public static void SaveMainDoorKey(MainDoorKeyScript mainDoorKeyScript)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream fileStream = new FileStream(PathForFile(), FileMode.Create);

        MainDoorDataScript mainDoorDataScript = new MainDoorDataScript(mainDoorKeyScript);

        binaryFormatter.Serialize(fileStream, mainDoorDataScript);
        fileStream.Close();
    }

    public static MainDoorDataScript LoadMainDoorKey()
    {
        if (File.Exists(PathForFile()))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(PathForFile(), FileMode.Open);

            MainDoorDataScript mainDoorDataScript = binaryFormatter.Deserialize(fileStream) as MainDoorDataScript;
            fileStream.Close();

            return mainDoorDataScript;
        }
        else
        {
            Debug.LogError("File not found");
            return null;
        }
    }

    private static string PathForFile()
    {
        string filePath = Application.persistentDataPath + "/doorkeys";
        return filePath;
    }
}
