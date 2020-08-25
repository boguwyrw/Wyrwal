using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
        SaveLoadSystemScript.SavePlayerRobot(FindObjectOfType<PlayerRobotScript>());
        SaveLoadBackpackSystemScript.SaveBackpackItem(FindObjectOfType<BackpackScript>());
        SaveLoadMainDoorSystemScript.SaveMainDoorKey(FindObjectOfType<MainDoorKeyScript>());
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
