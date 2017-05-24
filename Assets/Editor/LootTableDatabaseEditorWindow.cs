using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class LootTableDatabaseEditorWindow : EditorWindow
{
    private GUIStyle Header = new GUIStyle();
    public static List<LootTable> tables = new List<LootTable>();
    static string path;
    public static List<string> allFiles = new List<string>();

    [MenuItem("Tools/LootTableDatabase")]
    static void Init()
    {
        var window = EditorWindow.GetWindow(typeof(LootTableDatabaseEditorWindow));
        window.Show();

        path = Application.dataPath + "/Resources/Tables/";
        allFiles.AddRange(Directory.GetFiles(path, "*.asset"));
        foreach (var file in allFiles)
        {
            var relpath = file.Substring(path.Length - file.Length);
            var table = AssetDatabase.LoadAssetAtPath<LootTable>(relpath);
        }
    }
    private void OnGUI()
    {
        Header.alignment = TextAnchor.UpperCenter;
        Header.fontStyle = FontStyle.BoldAndItalic;
        Header.fontSize = 25;
        Header.normal.textColor = Color.cyan;
        GUILayout.Label("Loot Database", Header);
        GUILayout.Space(25);        
        EditorGUILayout.TextField("Loot Tables file path");        
    }
}
