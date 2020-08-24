using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadPlayerRobotScript : MonoBehaviour
{
    public void SavePlayerRobot()
    {
        SaveLoadSystemScript.SavePlayerRobot(GetComponent<PlayerRobotScript>());
    }

    public void LoadPlayerRobot()
    {
        PlayerRobotDataScript playerRobotDataScript = SaveLoadSystemScript.LoadPlayerRobot();

        Vector2 playerRobotPosition;
        playerRobotPosition.x = playerRobotDataScript.playerRobotPosition[0];
        playerRobotPosition.y = playerRobotDataScript.playerRobotPosition[1];

        transform.position = playerRobotPosition;
    }
}
