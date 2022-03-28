using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class ShopUpgradeCost : ScriptableObject
{
    public List<int> listOfCosts = new List<int>();
}
