using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject healthPotionPrefab;
    public GameObject manaPotionPrefab;
    public GameObject levelGroundPrefab;

	// Use this for initialization
	void Start ()
    {
        Instantiate(playerPrefab);
        Instantiate(healthPotionPrefab);
        Instantiate(manaPotionPrefab);
        Instantiate(levelGroundPrefab);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
