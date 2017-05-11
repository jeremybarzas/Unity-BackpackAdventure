using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "CharacterConfig")]

public class CharacterConfig : ScriptableObject
{
    public string characterName;
    public int health;

    public Backpack backpack;    
}
