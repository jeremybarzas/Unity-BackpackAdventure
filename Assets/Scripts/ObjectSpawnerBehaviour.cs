using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnerBehaviour : MonoBehaviour
{
    public GameObject handgunPrefab;
    public GameObject healthPotionPrefab;
    public GameObject heavyArmorPrefab;
    public GameObject levelGroundPrefab;
    public GameObject lightArmorPrefab;
    public GameObject longswordPrefab;
    public GameObject manaPotionPrefab;
    public GameObject playerPrefab;

    public List<GameObject> possibleItems = new List<GameObject>();

    private void ReinstantiateItem(Item item)
    {
        Debug.Log("reinstantiate this item: " + item.itemName);
        var playertransform = FindObjectOfType<PlayerBehaviour>().transform;
        foreach (var prefab in possibleItems)
            if (prefab.CompareTag(item.itemName))
            {
                var go = Instantiate(prefab, playertransform.position, transform.rotation);
                go.GetComponent<ItemBehaviour>().SetItem(item);
            }
    }

    private void Awake()
    {
        possibleItems.Add(playerPrefab);
        possibleItems.Add(levelGroundPrefab);
        possibleItems.Add(healthPotionPrefab);
        possibleItems.Add(manaPotionPrefab);
        possibleItems.Add(handgunPrefab);
        possibleItems.Add(longswordPrefab);
        possibleItems.Add(lightArmorPrefab);
        possibleItems.Add(heavyArmorPrefab);

        foreach (var prefab in possibleItems)
            Instantiate(prefab);

        BackpackBehaviour.itemDropped.AddListener(ReinstantiateItem);
    }
}