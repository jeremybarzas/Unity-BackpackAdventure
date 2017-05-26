using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackLoaderBehaviour : MonoBehaviour
{
    public BackpackLoader backpackLoader;
    public PlayerBehaviour playerBehaviour;
    public BackpackBehaviour playerBackpackBehaviour;

    public void LoadBackpack()
    {
        var bp = backpackLoader.LoadBackpack("PlayerBackpack");
        playerBackpackBehaviour.SetBackpack(bp);
    }

    void SetPlayer(PlayerBehaviour pb)
    {
        playerBehaviour = pb;
        playerBackpackBehaviour = pb.gameObject.GetComponent<BackpackBehaviour>();
    }

    void Awake()
    {
        PlayerBehaviour.onPlayerLoaded.AddListener(SetPlayer);        
    }
}
