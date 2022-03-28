using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public ShopUpgradeCost shopLevelList;
    public ShopLevel currentLevel;
    public TextMeshProUGUI shopLevel;
    public TextMeshProUGUI upgradeCost;
    public CurrencyInventory currentWealth;
    public Button thisButton;


    private void Start()
    {
        thisButton.onClick.AddListener(onButtonClick);
    }

    public void onButtonClick()
    {
        if (currentWealth.numberofcurrency >= shopLevelList.listOfCosts[currentLevel.Level])
        {

            currentWealth.numberofcurrency -= shopLevelList.listOfCosts[currentLevel.Level];
            
            currentLevel.Level += 1;
            
        }
    }

    private void Update()
    {
        
        shopLevel.text = "Level " + (currentLevel.Level+1);
        upgradeCost.text = " " + shopLevelList.listOfCosts[currentLevel.Level];

    }
}
