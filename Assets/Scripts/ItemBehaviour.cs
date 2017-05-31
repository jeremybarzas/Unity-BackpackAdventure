using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{   
    public Item config_item;
    public Item runtime_item;
    public static ItemPickedUp itemPickedUp = new ItemPickedUp();

    private bool playerContact;
    private BackpackBehaviour bp;

    void Start()
    {
        SetItem(config_item);
    }
    public void SetItem(Item item)
    {
        runtime_item = Instantiate(item);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            playerContact = true;
            bp = other.gameObject.GetComponent<BackpackBehaviour>();                       
        }
    }

    void OnTriggerExit(Collider other)
    {
        playerContact = false;        
    }

    void PickupItem()
    {
        if (playerContact)
        {
            if (bp)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    bool added = bp.AddItem(runtime_item);
                    if (added == true)
                    {
                        Debug.Log("You picked up " + config_item.itemName + ".");
                        itemPickedUp.Invoke(runtime_item);
                        Destroy(gameObject);
                    }
                }
            }
        }
    }

    void Update()
    {
        PickupItem();
    }
}
