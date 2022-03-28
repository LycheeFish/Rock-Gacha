using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class TenItemHolder : ScriptableObject
{
   public List<InventoryItem> tenSummon = new List<InventoryItem>();
}
