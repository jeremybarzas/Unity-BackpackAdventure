﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemBehaviour : MonoBehaviour
{
    [System.Serializable]
    
    public class OnItemAdd : UnityEvent{}
    public class OnItemAddWithString : UnityEvent<string> { }
    public OnItemAdd onItemAdd;
    public OnItemAddWithString onItemAddWithString;
    public Item itemConfig;
    private Item itemRuntime;
    [HideInInspector]
    public string itemName;
    [HideInInspector]
    public string itemID;
    [HideInInspector]
    public float weight;

    // Use this for initialization
    void Start()
    {
        onItemAddWithString.Invoke(itemName);
        onItemAdd.Invoke();
        itemRuntime = Instantiate(itemConfig);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if (other.gameObject.GetComponent<BackpackBehaviour>())
            {
                other.gameObject.GetComponent<BackpackBehaviour>().AddItem(itemRuntime);
            }
        }
    }

}

