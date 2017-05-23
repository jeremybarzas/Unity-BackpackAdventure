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
    void Update()
    {
        DropItem();
    }
    public void AddItem(Item item)
    {
        if (contents.Count < capacity)
        {
            contents.Add(item);
        }
    }

    public void DropItem()
    {
        if (Input.GetKeyDown("g"))
        {
        int last = contents.Count - 1;
        Item item = contents[last];
            Instantiate(item, gameObject.transform);
            contents.RemoveAt(last);
        }
    }

    //code for manual droppage.
}
