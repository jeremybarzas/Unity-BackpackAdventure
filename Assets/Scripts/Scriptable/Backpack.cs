using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Backpack")]

public class Backpack : ScriptableObject
{
    public int capacity;
    public List<Item> contents;
}
