using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    public Item itemConfig;
    private Item itemRuntime;
    public static ItemPickedUp itempickedup = new ItemPickedUp();

    void Start()
    {
        //itemRuntime = Instantiate(itemConfig);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            var bp = other.gameObject.GetComponent<BackpackBehaviour>();
            if (bp)
            {
                bool stored = bp.AddItem(itemConfig);
                if (stored)
                {
                    itempickedup.Invoke(itemConfig);
                }                
            }
        }
    }
}
