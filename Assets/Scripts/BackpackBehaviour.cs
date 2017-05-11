using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackBehaviour : MonoBehaviour
{
    public Backpack backpackConfig;
    public List<Item> contents;
    public float maxWeight = 99999999;
    private float currentWeight;

    // Use this for initialization
    void Start ()
    {
        contents = new List<Item>();
        backpackConfig.contents.ForEach(i => contents.Add(Instantiate(i)));
        //maxWeight = backpackConfig.maxWeight;
	}

    public void AddItem(Item item)
    {        
       contents.Add(item);       
        
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
