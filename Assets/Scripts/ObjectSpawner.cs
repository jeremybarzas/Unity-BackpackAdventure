using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject levelGroundPrefab;
    public GameObject healthPotionPrefab;
    public GameObject manaPotionPrefab;
    public GameObject handgunPrefab;
    public GameObject longSwordPrefab;
    public GameObject lightArmorPrefab;
    public GameObject heavyArmorPrefab;

    void ReinstantiateItem(Item item)
    {
        Debug.Log("reinstantiate this item: " + item.itemName);
        var playertransform = FindObjectOfType<PlayerBehaviour>().transform;

        // only works with manaPotionPrefab because it is hard set in code
        // need to figure out a way to do the item that was dropped
        var go = Instantiate(manaPotionPrefab, playertransform.position, transform.rotation);
        go.GetComponent<ItemBehaviour>().SetItem(item);
    }

    void Awake()
    {
        Instantiate(playerPrefab);
        Instantiate(levelGroundPrefab);
        Instantiate(healthPotionPrefab);
        Instantiate(manaPotionPrefab);
        Instantiate(handgunPrefab);
        Instantiate(longSwordPrefab);
        Instantiate(lightArmorPrefab);
        Instantiate(heavyArmorPrefab);
        BackpackBehaviour.itemDropped.AddListener(ReinstantiateItem);
    }
}
