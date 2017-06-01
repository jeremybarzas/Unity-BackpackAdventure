using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    public static ItemPickedUp itemPickedUp = new ItemPickedUp();
    private BackpackBehaviour bp;
    public Item config_item;

    private bool playerContact;
    public Item runtime_item;

    private void Start()
    {
        SetItem(config_item);
    }

    public void SetItem(Item item)
    {
        runtime_item = Instantiate(item);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerContact = true;
            bp = other.gameObject.GetComponent<BackpackBehaviour>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        playerContact = false;
    }

    private void PickupItem()
    {
        if (playerContact)
            if (bp)
                if (Input.GetKeyDown(KeyCode.F))
                {
                    var added = bp.AddItem(runtime_item);
                    if (added)
                    {
                        Debug.Log("You picked up " + config_item.itemName + ".");
                        itemPickedUp.Invoke(runtime_item);
                        Destroy(gameObject);
                    }
                }
    }

    private void Update()
    {
        PickupItem();
    }
}