using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestUI : MonoBehaviour
{    
    Text label;
	void Start ()
    {
        label = GetComponent<Text>();
        BackpackBehaviour.onBackPackChange.AddListener(SetText);        
	}
    void OnDisable()
    {
        BackpackBehaviour.onBackPackChange.RemoveListener(SetText);
    }
	void SetText(Backpack value)
    {
        var text = "";        
        value.contents.ForEach(item => text += item.itemName + "\n");
        text += "\n";
        label.text = text;
    }
}
