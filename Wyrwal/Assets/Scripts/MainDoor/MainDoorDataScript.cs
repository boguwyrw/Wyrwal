using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MainDoorDataScript
{
    public string nameOfKey;

    public MainDoorDataScript(MainDoorKeyScript mainDoorKeyScript)
    {
        nameOfKey = mainDoorKeyScript.nameOfKeyToDestroy;
    }
}
