using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = "Loot Table")]
public class LootTable : ScriptableObject
{
    [System.Serializable]
    public class ItemDrop
    {
        public Item item;
        [Range(0, 1)]
        public float dropChance;
    }
    [SerializeField]
    private List<ItemDrop> droppableItems;
    [SerializeField]
    private List<Item> dropResults;    
    public List<Item> GetDrops()
    {
        List<Item> actualDrops = new List<Item>();
        foreach (ItemDrop itemdrop in droppableItems)
        {
            if (actualDrops.Count <= droppableItems.Count)
            {
                float randomRoll = Random.Range(0.0f, 1.0f);
                if (itemdrop.dropChance > randomRoll)
                {
                    actualDrops.Add(itemdrop.item);
                }
            }
        }
        dropResults = actualDrops;
        return actualDrops;
    }
}
