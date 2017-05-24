using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackSaverBehaviour : MonoBehaviour
{
    public Backpack backPack;
    public string fileName = "default-backpack";

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.Assertions.Assert.IsNotNull(backPack, "Please assign backpack...");
            BackpackSaver.Instance.SaveBackpack(backPack, fileName);
        }        
	}
}
