using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject healthPotionPrefab;
    public GameObject manaPotionPrefab;

	// Use this for initialization
	void Start ()
    {
        var player = Instantiate(playerPrefab);
        var healthPotion = Instantiate(healthPotionPrefab);
        var manaPotion = Instantiate(manaPotionPrefab);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
