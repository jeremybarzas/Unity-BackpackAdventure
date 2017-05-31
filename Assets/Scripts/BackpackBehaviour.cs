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
        onBackPackChange.Invoke(backpackRuntime);
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
            onBackPackChange.Invoke(backpackRuntime);
            return true;
        }
        return false;
    }

    public void SetBackpack(Backpack bp)
    {
        backpackRuntime.contents = new List<Item>();
        foreach (Item item in bp.contents)
        {
            backpackRuntime.contents.Add(item);
        }
        onBackPackChange.Invoke(backpackRuntime);
    }

    void Awake()
    {
        backpackRuntime = Instantiate(backpackConfig);
        onBackPackChange = new BackPackEvent();
    }
    void Start()
    {
        onBackPackChange.Invoke(backpackRuntime);
    }

    public static BackPackEvent onBackPackChange;
    public class BackPackEvent : UnityEvent<Backpack>
    {

    }

}
