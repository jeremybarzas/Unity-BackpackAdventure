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
        Instantiate(item);
    }

    void OnEnable()
    {
        ItemBehaviour.itemPickedUp.AddListener(ReinstantiateItem);
    }

    void Awake()
    {
        Instantiate(playerPrefab);
        Instantiate(healthPotionPrefab);
        Instantiate(manaPotionPrefab);
        Instantiate(levelGroundPrefab);
    }
}
