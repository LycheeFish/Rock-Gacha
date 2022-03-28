using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalGain : MonoBehaviour
{

    
    public CurrencyInventory currentWealth;
    public TotalGainObject currentGain;

    private float waitTime = 1.0f;
    private float timer = 0.0f;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public int OverallGain()
    {
        currentGain.totalGain = gameObject.GetComponent<ShopTwoUpgrade>().ShopTwoTotal();
        return currentGain.totalGain;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            timer = timer - waitTime;
            
            currentWealth.numberofcurrency += OverallGain();

            
        }

    }
}
