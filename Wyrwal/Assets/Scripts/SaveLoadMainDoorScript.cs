using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadMainDoorScript : MonoBehaviour
{
    private string keyName;
    private GameObject keyObject;

    public void SaveKeyFromMainDoor()
    {
        SaveLoadMainDoorSystemScript.SaveMainDoorKey(GetComponent<MainDoorKeyScript>());
    }

    public void LoadKeyFromMainDoor()
    {
        MainDoorDataScript mainDoorDataScript = SaveLoadMainDoorSystemScript.LoadMainDoorKey();

        keyName = mainDoorDataScript.nameOfKey;
        Debug.Log(keyName);
        keyObject = GameObject.Find(keyName);
        Destroy(keyObject);
    }
}
