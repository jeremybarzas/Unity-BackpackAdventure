using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Potion/ManaPotion")]

public class ManaPotion : Consumable
{
    new public string itemName;
    new public string itemID;
    public int manaAmount;
}
