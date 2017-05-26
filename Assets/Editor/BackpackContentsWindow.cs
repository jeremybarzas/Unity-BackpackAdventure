using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BackpackContentsWindow : EditorWindow
{
    public static PlayerBehaviour playerBehaviour;
    public static BackpackBehaviour playerBackpackBehaviour;

    [MenuItem("Backpack/Contents")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(BackpackContentsWindow));
        playerBehaviour = FindObjectOfType<PlayerBehaviour>();
        playerBackpackBehaviour = FindObjectOfType<BackpackBehaviour>();
    }

    void OnGUI()
    {
        GUILayout.Label("\nBackpack Contents", EditorStyles.boldLabel);
        foreach (var item in playerBackpackBehaviour.backpackRuntime.contents)
        {
            GUILayout.BeginHorizontal();
            GUILayout.TextField("Item");
            GUILayout.TextField(item.itemName);
            GUILayout.EndHorizontal();
        }
    }    
}
