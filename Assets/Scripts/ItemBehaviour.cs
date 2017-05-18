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

    public static ItemPickedUp itempickedup = new ItemPickedUp();

    void Start()
    {
        itemRuntime = Instantiate(itemConfig);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if (other.gameObject.GetComponent<BackpackBehaviour>())
            {
                other.gameObject.GetComponent<BackpackBehaviour>().AddItem(itemRuntime);
                itempickedup.Invoke(itemRuntime);
            }
        }
    }
}
