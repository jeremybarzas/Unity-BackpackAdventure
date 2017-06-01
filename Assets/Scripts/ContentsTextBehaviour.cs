using UnityEngine;
using UnityEngine.UI;

public class ContentsTextBehaviour : MonoBehaviour
{
    public Text label;
    private Backpack playerBackpack;

    private void Start()
    {        
        playerBackpack = FindObjectOfType<BackpackBehaviour>().backpackRuntime;
        SetText(playerBackpack);
    }

    private void Awake()
    {
        label = GetComponent<Text>();
        BackpackBehaviour.onBackPackChange.AddListener(SetText);
    }

    private void OnDisable()
    {
        BackpackBehaviour.onBackPackChange.RemoveListener(SetText);
    }

    private void SetText(Backpack value)
    {
        var text1 = "Backpack Capcity: " + value.capacity;
        var text2 = "\nItem Count: " + value.contents.Count;
        var text3 = "\n\nCurrent Contents:\n\n";
        var text4 = "";
        value.contents.ForEach(item => text4 += item.itemName + "\n");
        text4 += "\n";
        label.text = text1 + text2 + text3 + text4;
    }
}