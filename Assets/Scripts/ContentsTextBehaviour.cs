using UnityEngine;
using UnityEngine.UI;

public class ContentsTextBehaviour : MonoBehaviour
{
    private Text label;
    private Backpack playerBackpack;

    private void Start()
    {
        label = GetComponent<Text>();
        playerBackpack = FindObjectOfType<BackpackBehaviour>().backpackRuntime;
        SetText(playerBackpack);
    }

    private void Awake()
    {
        BackpackBehaviour.onBackPackChange.AddListener(SetText);
    }

    private void OnDisable()
    {
        BackpackBehaviour.onBackPackChange.RemoveListener(SetText);
    }

    private void SetText(Backpack value)
    {
        var text = "Backpack Contents\n\n";
        value.contents.ForEach(item => text += item.itemName + "\n");
        text += "\n";
        label.text = text;
    }
}