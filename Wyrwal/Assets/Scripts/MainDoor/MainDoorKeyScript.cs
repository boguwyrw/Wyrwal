using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoorKeyScript : MonoBehaviour
{
    public string nameOfKeyToDestroy;

    private void Update()
    {
        nameOfKeyToDestroy = MainDoorScript.destroyKeyName;
    }

}
