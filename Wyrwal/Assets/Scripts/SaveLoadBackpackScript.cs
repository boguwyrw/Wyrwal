using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadBackpackScript : MonoBehaviour
{
    private string itemName;

    public void SaveBackpack()
    {
        SaveLoadBackpackItemScript.SaveBackpackItem(GetComponent<BackpackScript>());
    }

    public void LoadBackpack()
    { 
        BackpackDataScript backpackDataScript = SaveLoadBackpackItemScript.LoadBackpackItem();

        itemName = backpackDataScript.itemInBackpackName;
        GameObject itemObject = GameObject.Find(itemName);
        itemObject.transform.parent = transform;
        itemObject.transform.position = transform.position;
    }
    
}
