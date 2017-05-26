using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackSaverBehaviour : MonoBehaviour
{
    public BackpackSaver backpackSaver;
    public PlayerBehaviour playerBehaviour;
    public BackpackBehaviour playerBackpackBehaviour;
    
    public void SaveBackpack()
    {
        backpackSaver.SaveBackpack(playerBackpackBehaviour.backpackRuntime, "PlayerBackpack");
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
