using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
//Conner
[CreateAssetMenu(menuName ="Loot Table")]
public class LootTable : ScriptableObject {
     
  
    [System.Serializable]
    public class ItemDrop
    {
        public Item droppedItem;
        [Range(0f, 1f)]
        public float dropChance;

}
    public float randomRoll;
    public List<ItemDrop> Drops;
    public List<Item> GetDrops()
    {
        randomRoll = UnityEngine.Random.Range(0f, 1f);
        List<Item> itemsDropped = new List<Item>();
        foreach (ItemDrop a in Drops)
        {
            if (a.dropChance > randomRoll)
                itemsDropped.Add(a.droppedItem);
        }
        return itemsDropped;
    }
    [CustomEditor(typeof(LootTable))]
    public class InspectorLootTable : Editor
    {
        string result = "";
        List<Item> Items = new List<Item>();
        public override void OnInspectorGUI()
        {
            var myTarget = target as LootTable;
            if (GUILayout.Button("this Button"))
            {
                Items = myTarget.GetDrops();
            }
            foreach(var item in Items)
            {
                Debug.Log(item.name);
            }
            EditorGUILayout.LabelField("result", result);
            base.OnInspectorGUI();
        }
        
    }
}
