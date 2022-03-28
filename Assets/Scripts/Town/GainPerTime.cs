using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class GainPerTime : ScriptableObject
{
    public List<int> timeGain = new List<int>();
}
