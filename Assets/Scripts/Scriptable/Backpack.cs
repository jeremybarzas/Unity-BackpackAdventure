using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BackpackConfig", menuName = "BackpackConfig")]

public class Backpack : ScriptableObject
{
    public float maxWeight;
    public List<Item> contents;
}
