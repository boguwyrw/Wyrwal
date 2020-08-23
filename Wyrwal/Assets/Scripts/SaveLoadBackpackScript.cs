using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadBackpackScript : MonoBehaviour
{
    private Vector2 itemInBackpackPosition;
    private BackpackScript backpackScript;
    private string itemName;

    private void Start()
    {
        backpackScript = FindObjectOfType<BackpackScript>();
    }

    public void SaveBackpack()
    {
        SaveLoadBackpackItemScript.SaveBackpackItem(GetComponent<BackpackScript>());
    }

    public void LoadBackpack()
    { 
        BackpackDataScript backpackDataScript = SaveLoadBackpackItemScript.LoadBackpackItem();

        bool itemInBackpack = backpackDataScript.itemIsInBackpack;
        itemName = backpackDataScript.itemInBackpackName;
        itemInBackpackPosition.x = backpackDataScript.backpackItemPosition[0];
        itemInBackpackPosition.y = backpackDataScript.backpackItemPosition[1];

        itemName = backpackScript.backpackItemName;
        Debug.Log(itemName);
        GameObject backpackItem = GameObject.Find(itemName);
        //Debug.Log(backpackItem.name);
        //backpackItem.transform.parent = transform;
        //transform.GetChild(0).position = transform.position;

        /*
        if (itemInBackpack)
        {
            itemName = backpackScript.GetBackpackItemName();
            GameObject backpackItem = GameObject.Find(itemName);
            Debug.Log(backpackItem.name);
            //backpackItem.transform.parent = transform;
            transform.GetChild(0).position = itemInBackpackPosition;
        }
        */
    }
    
}
