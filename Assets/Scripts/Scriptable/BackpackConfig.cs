using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BackpackConfig", menuName = "BackpackConfig")]

public class BackpackConfig : ScriptableObject
{
    public string backpackName;
    public float maxWeight;

    public List<Item> contents = new List<Item>();
}
