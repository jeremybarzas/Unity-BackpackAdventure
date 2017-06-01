using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Character/Player")]
public class Player : ScriptableObject
{
    public PlayerInfo stats;

    [Serializable]
    public class PlayerInfo
    {
        public int health;
        public string playerName;
        public float speed;
    }
}