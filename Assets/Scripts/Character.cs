using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterConfig characterConfig;
    private Backpack backpack;
        
    // Use this for initialization
    void Start ()
    {
        backpack = characterConfig.backpack;
	}

    public bool PickupItem(Item item)
    {
        bool result = backpack.AddItem(item);        
        return result;
    }
    public bool DropItem(Item item)
    {
        bool result = backpack.RemoveItem(item);
        return result;
    }
}
