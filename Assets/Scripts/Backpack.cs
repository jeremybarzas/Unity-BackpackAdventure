using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    public BackpackConfig backpackConfig;
    public List<Item> contents;
    public float maxWeight;
    private float currentWeight;

    // Use this for initialization
    void Start ()
    {
        contents = backpackConfig.contents;
        maxWeight = backpackConfig.maxWeight;
	}

    public bool AddItem(Item item)
    {
        if (currentWeight + item.weight < maxWeight)
        {
            contents.Add(item);
            return true;
        }
        return false;
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
