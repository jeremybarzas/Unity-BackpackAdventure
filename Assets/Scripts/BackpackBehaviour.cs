using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BackpackBehaviour : MonoBehaviour
{    
    public Backpack backpackConfig;
    private Backpack backpackRuntime;
    [HideInInspector]
    public int itemAmount;
    public void AddItem(Item item)
    {
        if (itemAmount < backpackConfig.capacity)
        {
            backpackConfig.contents.Add(item);
            itemAmount += 1;
        }
    }
    public bool RemoveItem(Item item)
    {
        int precount = backpackRuntime.contents.Count;
        backpackRuntime.contents.Remove(item);
        if (backpackRuntime.contents.Count < precount)
        {
            return true;
        }
        return false;
    }    

    void Start()
    {
        backpackRuntime = Instantiate(backpackConfig);
    }

    void Update()
    {

    }
}
