using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "CharacterConfig")]

public class CharacterConfig : ScriptableObject
{
    public string chracterName;
    public int health;

    public Inventory inventory;
}
