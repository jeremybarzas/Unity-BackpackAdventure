using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Potion/HealthPotion")]

public class HealthPotion : Consumable
{
    new public string itemName;
    new public string itemID;
    public int healthAmount;
}
