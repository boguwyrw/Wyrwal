using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerRobotDataScript
{
    public float[] playerRobotPosition;

    public PlayerRobotDataScript(PlayerRobotScript playerRobotScript)
    {
        playerRobotPosition = new float[2];
        playerRobotPosition[0] = playerRobotScript.transform.position.x;
        playerRobotPosition[1] = playerRobotScript.transform.position.y;
    }
}
