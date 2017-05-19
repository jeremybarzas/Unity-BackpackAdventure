using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Character/Player")]
public class Player : ScriptableObject
{
    [System.Serializable]
    public class PlayerInfo
    {
        public string playerName;
        public int health;
        public float speed;
    }
    public PlayerInfo stats;
}
