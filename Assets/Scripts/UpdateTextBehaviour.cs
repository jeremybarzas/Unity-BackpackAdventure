using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTextBehaviour : MonoBehaviour
{
    public Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void OnEnable()
    {
        ItemBehaviour.itemPickedUp.AddListener(ChangeItemText);
    }
    void OnDisable()
    {
        ItemBehaviour.itemPickedUp.RemoveListener(ChangeItemText);
    }

    void ChangeItemText(Item item)
    {
        text.text = item.itemName;
    }
}
