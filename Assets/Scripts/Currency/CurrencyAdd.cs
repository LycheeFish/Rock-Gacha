using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyAdd : MonoBehaviour
{
    //adds currency to scriptable object [number of currency]
    public CurrencyInventory Inventory;
    public ShopLevel rockPerClick;
    public Button thisButton;

    void Start()
    {
        thisButton.onClick.AddListener(Addcurrency);
    }
    public void Addcurrency()
    {
        Inventory.numberofcurrency += ((rockPerClick.Level)+1);
    }
}
