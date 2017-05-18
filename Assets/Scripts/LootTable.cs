using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
[CreateAssetMenu(menuName ="Loot Table")]
public class LootTable : ScriptableObject {
     
  
    [System.Serializable]
    public class ItemDrop
    {
        public Item droppedItem;
        public float dropChance = UnityEngine.Random.Range(0f, 1f);

}
    public float randomRoll = UnityEngine.Random.Range(0f, 1f);
    public List<ItemDrop> Drops;
    List<ItemDrop> GetDrops()
    {
        foreach
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
