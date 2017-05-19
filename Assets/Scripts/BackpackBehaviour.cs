using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BackpackBehaviour : MonoBehaviour
{    
    public Backpack backpackConfig;
    private Backpack backpackRuntime;
    
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
