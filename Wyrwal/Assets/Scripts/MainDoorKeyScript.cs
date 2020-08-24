using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoorKeyScript : MonoBehaviour
{
    private MainDoorScript mainDoorScript;
    public string nameOfKeyToDestroy;

    private void Start()
    {
        mainDoorScript = FindObjectOfType<MainDoorScript>();
    }

    private void Update()
    {
        nameOfKeyToDestroy = mainDoorScript.destroyKeyName;
        Debug.Log("MainDoorKeyScript: " + nameOfKeyToDestroy);
    }

}
