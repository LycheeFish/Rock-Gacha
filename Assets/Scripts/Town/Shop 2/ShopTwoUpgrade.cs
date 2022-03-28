using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTwoUpgrade : MonoBehaviour
{
    public ShopLevel currentLevel;
    public GainPerTime rockPerTime;

    

    public int ShopTwoTotal()
    {
        if(currentLevel.Level > 0)
        {
            return rockPerTime.timeGain[(currentLevel.Level) - 1];
            
        }
        else
        {
            return 0;
        }
    }
}
