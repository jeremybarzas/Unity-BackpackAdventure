using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BackpackBehaviour : MonoBehaviour
{    
    public Backpack backpackConfig;
    public Backpack backpackRuntime;
    public static ItemDropped itemDropped = new ItemDropped();

    public bool AddItem(Item item)
    {
        if (backpackRuntime.contents.Count + 1 > backpackRuntime.capacity)
            return false;
        backpackRuntime.contents.Add(item);
        return true;
    }

    public bool RemoveItem(Item item)
    {        
        int precount = backpackRuntime.contents.Count;
        backpackRuntime.contents.Remove(item);
        if (backpackRuntime.contents.Count < precount)
        {
            Debug.Log("You dropped " + item.itemName + ".");
            itemDropped.Invoke(item);
            return true;
        }
        return false;
    }

    public void SetBackpack(Backpack bp)
    {
        backpackRuntime.contents = bp.contents;
    }

    void Awake()
    {
        backpackRuntime = Instantiate(backpackConfig);
    }    
}
