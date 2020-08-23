using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BackpackDataScript
{
    public string itemInBackpackName;

    public BackpackDataScript(BackpackScript backpackScript)
    {
        itemInBackpackName = backpackScript.backpackItemName;
    }
}
