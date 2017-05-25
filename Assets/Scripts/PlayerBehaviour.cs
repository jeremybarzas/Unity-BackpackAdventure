using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public Player playerConfig;
    private Player playerRuntime;
    
	void Start ()
    {
        FindObjectOfType<BackpackLoaderBehaviour>().backpackBehaviour = GetComponent<BackpackBehaviour>();
        playerRuntime = Instantiate(playerConfig);
	}
}
