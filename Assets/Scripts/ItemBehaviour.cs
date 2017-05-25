using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    public Item itemConfig;
    private Item itemRuntime;
    public static ItemPickedUp itemPickedUp = new ItemPickedUp();

    void OnTriggerEnter(Collider other)
    {  
        if(other.gameObject.CompareTag("Player"))
        {
            var bp = other.gameObject.GetComponent<BackpackBehaviour>();
            if(bp)
            {
                bool added = bp.AddItem(itemConfig);
                if (added == true)
                {
                    Debug.Log("You picked up " + itemConfig.itemName + ".");
                    itemPickedUp.Invoke(itemConfig);
                    Destroy(gameObject);
                }
            }
        }
    }
}
