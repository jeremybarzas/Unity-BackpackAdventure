using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "BackpackLoader", menuName = "GameState/Loaders/BackpackLoader", order = 1)]
public class BackpackLoader : ScriptableObject
{
    private static BackpackLoader _instance;

    public static BackpackLoader Instance
    {
        get
        {
            // if we dont have try to find it
            if (!_instance)
                _instance = Resources.FindObjectsOfTypeAll<BackpackLoader>().FirstOrDefault();
            // if we still dont have it make one
            if (!_instance)
                _instance = CreateInstance<BackpackLoader>();
            return _instance;
        }
    }
    public Backpack LoadBackpack(string filename)
    {
        var path = Application.dataPath + "/StreamingAssets/" + filename + ".json";
        var json = System.IO.File.ReadAllText(path);
        var backpack = CreateInstance<Backpack>();
        JsonUtility.FromJsonOverwrite(json, backpack);
        UnityEngine.Assertions.Assert.IsNotNull(backpack);
        return backpack;        
    }
}
