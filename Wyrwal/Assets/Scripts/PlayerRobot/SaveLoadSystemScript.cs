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

    private static string PathForFile()
    {
        string filePath = Application.persistentDataPath + "/game";
        return filePath;
    }
}
