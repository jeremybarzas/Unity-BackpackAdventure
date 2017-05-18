using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
public class LootTableEditor : EditorWindow {
   
    static string path;
    public static List<string> assetStrings;
    public static List<string> allFiles;
    public static List<LootTable> tables = new List<LootTable>();
    [MenuItem("Tools/LootTableDatabase")]
    static void Init()
    {
        var window = EditorWindow.GetWindow(typeof(LootTableEditor));
        window.Show();
        path = Application.dataPath + "/Resources/Tables/";
        allFiles.AddRange(Directory.GetFiles(path, "*.asset"));
        foreach(var file in allFiles)
        {
            var relPath = file.Substring(path.Length - file.Length);
            var table = AssetDatabase.LoadAssetAtPath<LootTable>(relPath);
            tables.Add(table);
        }
    }
    private GUIStyle Header = new GUIStyle();
    private void OnGUI()
    {
        Header.alignment = TextAnchor.UpperCenter;
        Header.fontStyle = FontStyle.BoldAndItalic;
        Header.fontSize = 50;
        Header.normal.textColor = Color.cyan;
        GUILayout.Label("Loot Database", Header);
        GUILayout.Space(25);
        if (GUILayout.Button("this is a Button"))
        { }
        foreach (var assetString in assetStrings)
            GUILayout.TextField("Table", assetString);
        foreach (var table in tables)
            EditorGUILayout.TextField("table");
    }
}
