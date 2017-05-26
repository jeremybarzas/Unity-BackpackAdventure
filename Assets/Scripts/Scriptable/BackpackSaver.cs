using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "BackpackSaver", menuName = "GameState/Savers/BackpackSaver")]
public class BackpackSaver : ScriptableObject
{
    private static BackpackSaver _instance;
    
    public static BackpackSaver Instance
    {
        get
        {
            // if we dont have it try to find it
            if (!_instance)
                _instance = Resources.FindObjectsOfTypeAll<BackpackSaver>().FirstOrDefault();
            // if we still dont have it make one
            if (!_instance)
                _instance = CreateInstance<BackpackSaver>();
            return _instance;
        }
    }
    public void SaveBackpack(Backpack backpack, string filename)
    {
        var path = Application.dataPath + "/StreamingAssets/" + filename + ".json";
        var json = JsonUtility.ToJson(backpack, true);
        System.IO.File.WriteAllText(path, json);
    }
}
