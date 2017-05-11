using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "scriptableItem", menuName = "itemConfig")]
public class ItemConfig : ScriptableObject {
    public string itemName;
    public float itemID;
    public float weight;
}
