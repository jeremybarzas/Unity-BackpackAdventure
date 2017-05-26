using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject healthPotionPrefab;
    public GameObject manaPotionPrefab;
    public GameObject levelGroundPrefab;    

    void ReinstantiateItem(Item item)
    {
        Debug.Log("reinstantiate this item: " + item.itemName);
        var playertransform = FindObjectOfType<PlayerBehaviour>().transform;

        var go = Instantiate(manaPotionPrefab, playertransform.position, transform.rotation);
        go.GetComponent<ItemBehaviour>().SetItem(item);
    }

    void Awake()
    {
        Instantiate(playerPrefab);
        Instantiate(healthPotionPrefab);
        Instantiate(manaPotionPrefab);
        Instantiate(levelGroundPrefab);
        BackpackBehaviour.itemDropped.AddListener(ReinstantiateItem);
    }
}
