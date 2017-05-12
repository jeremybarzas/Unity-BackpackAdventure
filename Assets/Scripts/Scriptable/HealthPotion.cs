using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Potion/HealthPotion")]

public class HealthPotion : Potion
{
    public string itemName;
    public string itemID;
    public int healthAmount;
}
