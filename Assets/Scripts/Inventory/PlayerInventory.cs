using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class PlayerInventory : ScriptableObject
{
    public List<InventoryItem> Inventory = new List<InventoryItem>();
}
