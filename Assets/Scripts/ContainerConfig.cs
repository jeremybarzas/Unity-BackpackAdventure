using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ContainerConfig", menuName = "ContainerConfig")]

public class ContainerConfig : ScriptableObject
{
    public List<Item> contents;
}
