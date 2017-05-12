using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Potion/ManaPotion")]

public class ManaPotion : Potion
{
    public string itemName;
    public string itemID;
    public int manaAmount;
}
