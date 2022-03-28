using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyUpdate : MonoBehaviour
{
    public CurrencyInventory inventory;
    public TextMeshProUGUI currencydisplay;


    private void Awake()
    {
        currencydisplay.text = "" + inventory.numberofcurrency;
    }
    //changes text display using [number of currency]
    public void UpdateCurrencyCount()
    {
        currencydisplay.text = "" + inventory.numberofcurrency;
    }

    void Update()
    {
        currencydisplay.text = "" + inventory.numberofcurrency;
    }


}
