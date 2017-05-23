using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackBehaviour : MonoBehaviour
{
    public Backpack backpackConfig;
    public int capacity;
    public List<Item> contents;
    
    // Use this for initialization
    void Start ()
    {
        contents = new List<Item>(capacity);
	}

    public void AddItem(Item item)
    {
        if (contents.Count < capacity)
        { contents.Add(item);
        }
    }

    public bool RemoveItem(Item item)
    {
        int count = contents.Count;
        contents.Remove(item);
        if (contents.Count < count)
        {
            return true;
        }
        return false;
    }
    //code for manual droppage.
}
