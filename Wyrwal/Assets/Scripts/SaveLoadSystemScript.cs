using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoadSystemScript
{
    public static void SavePlayerRobot(PlayerRobotScript playerRobotScript)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream fileStream = new FileStream(PathForFile(), FileMode.Create);

        PlayerRobotDataScript playerRobotDataScript = new PlayerRobotDataScript(playerRobotScript);

        binaryFormatter.Serialize(fileStream, playerRobotDataScript);
        fileStream.Close();
    }
    /*
    public static void SaveBackpack(BackpackScript backpackScript)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream fileStream = new FileStream(PathForFile(), FileMode.Create);

        BackpackDataScript backpackDataScript = new BackpackDataScript(backpackScript);

        binaryFormatter.Serialize(fileStream, backpackDataScript);
        fileStream.Close();
    }
    */
    public static PlayerRobotDataScript LoadPlayerRobot()
    {
        if (File.Exists(PathForFile()))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(PathForFile(), FileMode.Open);

            PlayerRobotDataScript playerRobotDataScript = binaryFormatter.Deserialize(fileStream) as PlayerRobotDataScript;
            fileStream.Close();

            return playerRobotDataScript;
        }
        else
        {
            Debug.LogError("File not found");
            return null;
        }
    }
    /*
    public static BackpackDataScript LoadBackpack()
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
    */
    private static string PathForFile()
    {
        string filePath = Application.persistentDataPath + "/game";
        return filePath;
    }
}
