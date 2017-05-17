using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChangeBehaviour : MonoBehaviour
{
    public Text textToChange;

    public void ChangeText(ItemBehaviour item)
    {
        textToChange.text = item.itemName;
    }
}
