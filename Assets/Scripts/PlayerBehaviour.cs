using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerBehaviour : MonoBehaviour
{
    public Player playerConfig;
    public static OnPlayerLoaded onPlayerLoaded = new OnPlayerLoaded();

	void Start ()
    {        
        onPlayerLoaded.Invoke(this);
	}
    
    public class OnPlayerLoaded : UnityEvent<PlayerBehaviour> {}
}
