using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Backpack")]

public class Backpack : ScriptableObject
{
    public float maxWeight;
    public List<Item> contents;
}
