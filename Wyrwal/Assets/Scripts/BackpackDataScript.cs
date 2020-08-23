using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BackpackDataScript
{
    public float[] backpackItemPosition;
    public bool itemIsInBackpack;
    public string itemInBackpackName;

    public BackpackDataScript(BackpackScript backpackScript)
    {
        itemIsInBackpack = backpackScript.GetItemInBackpack();
        itemInBackpackName = backpackScript.backpackItemName;
        if (backpackScript.transform.childCount > 0)
        {
            backpackItemPosition = new float[2];
            backpackItemPosition[0] = backpackScript.transform.GetChild(0).position.x;
            backpackItemPosition[1] = backpackScript.transform.GetChild(0).position.y;
        }
    }
}
