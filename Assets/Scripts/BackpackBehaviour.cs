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
        contents = new List<Item>();
        capacity = backpackConfig.capacity;
        backpackConfig.contents.ForEach(i => contents.Add(Instantiate(i)));
	}


    public bool AddItem(Item item)
    {
        if (contents.Count + 1 > capacity)
            return false;
        contents.Add(item);
        return true;
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
}
