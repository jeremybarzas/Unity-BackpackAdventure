using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackSaverBehaviour : MonoBehaviour
{
    public BackpackSaver backpackSaver;
    public Backpack playerBackpack;

    public void SaveBackpack()
    {
        backpackSaver.SaveBackpack(playerBackpack, "PlayerBackpack");
    }

    void Start()
    {
        var player = FindObjectOfType<PlayerBehaviour>();
        playerBackpack = player.GetComponent<BackpackBehaviour>().backpackRuntime;
    }
}
