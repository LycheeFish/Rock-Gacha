using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu]
public class CheckifFound : ScriptableObject
{
    public List<Foundrock> rockFoundList = new List<Foundrock>();
}
