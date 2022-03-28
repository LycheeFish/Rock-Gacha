using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameClose : MonoBehaviour
{

    
    public TotalGainObject totalAdd;
    public CurrencyInventory currentWealth;
    public TimeObject timer;

    bool isPaused = false;
    DateTime startDate;
    DateTime endDate;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationFocus(bool focus)
    {
        isPaused = !focus;
    }

    private void OnApplicationPause(bool pause)
    {
        if (pause == true)
        {
            startDate = DateTime.Now;
            long currentTicks = startDate.Ticks;
            timer.startTimer = currentTicks;
        }
        else if (pause == false)
        {
            endDate = DateTime.Now;
            long endingTicks = endDate.Ticks;
            timer.endTimer = endingTicks;
            addCalculatedSpan((timer.endTimer) - (timer.startTimer));
        }
        
    }

    public void addCalculatedSpan(long difference)
    {
        TimeSpan elapsedSpan = new TimeSpan(difference);
        currentWealth.numberofcurrency += ((elapsedSpan.Seconds) * (totalAdd.totalGain));
    }
}
