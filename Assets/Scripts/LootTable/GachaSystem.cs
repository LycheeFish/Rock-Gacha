using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu]
public class GachaSystem : ScriptableObject
{
    //Drop func
    [Serializable]
    public class Drop
    {
        public InventoryItem drop;
        public int percentage;
    }
    public List<Drop> rockList;


    public int total; // total weight
    public int randomNum;

    public int totalPercentage()
    {
        total = 0;
        for (int i = 0; i < rockList.Count; i++)
        {
            total += rockList[i].percentage;

        }
        return total;
    }

    public InventoryItem GetDrop()
    {
        // tally the total weight
        // draw a random number between 0 and the total weight (100)
        // example; random number is 95, (95-90) <= 9 so it awards rock 2 

        int currTotal = totalPercentage();
        randomNum = UnityEngine.Random.Range(0, currTotal);
        Debug.Log("random number " + randomNum);
        for (int i = 0; i < rockList.Count; i++)
        {
            if (randomNum < rockList[i].percentage)
            {
                // award item;
                // Debug.Log(randomNum);
                Debug.Log("Award " + rockList[i].drop);
                return rockList[i].drop;
            }
            else
            {
                randomNum -= rockList[i].percentage;
            }
        }
        return null;
    }


}