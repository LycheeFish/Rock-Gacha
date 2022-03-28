using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class InventoryItem : ScriptableObject
{
    public string Name;
    public int ID;
    public Sprite imageName;
    public string Description;
    //public int Count;
    public string rarity;
}
