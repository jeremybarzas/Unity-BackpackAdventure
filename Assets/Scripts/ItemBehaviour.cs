using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
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
        itemRuntime = Instantiate(itemConfig);
    }
    void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log(other.name);
            if (other.gameObject.GetComponent<BackpackBehaviour>())
            {
                other.gameObject.GetComponent<BackpackBehaviour>().AddItem(itemRuntime);
               
            }
        }
        

    }
}

