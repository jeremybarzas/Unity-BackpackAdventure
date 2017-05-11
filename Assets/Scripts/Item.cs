using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemConfig itemConfig;
    public float weight;

    // Use this for initialization
    void Start ()
    {
        weight = itemConfig.weight;
    }
}
