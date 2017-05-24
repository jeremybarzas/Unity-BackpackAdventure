using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
//Conner
[CustomEditor(typeof(LootTable))]
public class LootTableRollDropButton : Editor
{
    public override void OnInspectorGUI()
    {
        LootTable lootTable = (LootTable)target;
        if (GUILayout.Button("Roll Drops", GUILayout.ExpandWidth(false)))
        {
            lootTable.GetDrops();
        }
        base.OnInspectorGUI();
    }
}
