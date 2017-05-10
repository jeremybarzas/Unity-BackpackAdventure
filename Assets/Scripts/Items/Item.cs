using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    public string name;
    public int itemID;
    public float weight;
}

public class Consumable : Item{
    public bool ammo;
    public bool potion;
    public int maxStackSize;
    public int currentStackSize;
}

