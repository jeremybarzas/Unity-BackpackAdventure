using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackLoaderBehaviour : MonoBehaviour
{
    public Backpack backPack = null;

    void Start()
    {
        UnityEngine.Assertions.Assert.IsNull(backPack);
        backPack = null;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            backPack = BackpackLoader.Instance.LoadBackpack("default-backpack");
        }
    }    
}
