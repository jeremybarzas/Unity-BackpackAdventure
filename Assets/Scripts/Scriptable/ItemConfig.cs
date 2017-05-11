using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemConfig", menuName = "ItemConfig")]

public class ItemConfig : ScriptableObject
{
    public string itemName;
    public string itemID;
    public float weight;
}
