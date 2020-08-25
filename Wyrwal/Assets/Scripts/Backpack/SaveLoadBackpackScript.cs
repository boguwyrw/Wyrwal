using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadBackpackScript : MonoBehaviour
{
    private string itemName;
    private GameObject itemObject;

    public void SaveBackpack()
    {
        SaveLoadBackpackSystemScript.SaveBackpackItem(GetComponent<BackpackScript>());
    }

    public void LoadBackpack()
    { 
        BackpackDataScript backpackDataScript = SaveLoadBackpackSystemScript.LoadBackpackItem();

        if (transform.childCount > 0)
        {
            itemName = backpackDataScript.itemInBackpackName;
            itemObject = GameObject.Find(itemName);
        }
        
        if (itemObject != null)
        {
            itemObject.transform.parent = transform;
            itemObject.transform.position = transform.position;
        }
    }
    
}
