using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackLoaderBehaviour : MonoBehaviour
{
    public BackpackLoader backpackLoader;
    public BackpackBehaviour backpackBehaviour;
    public Backpack playerBackpack;

    public void LoadBackpack()
    {
        playerBackpack = backpackLoader.LoadBackpack("PlayerBackpack");
    }

    void Start()
    {
        UnityEngine.Assertions.Assert.IsNull(playerBackpack);
        var player = FindObjectOfType<PlayerBehaviour>();
        playerBackpack = backpackBehaviour.backpackRuntime;
    }  
}
