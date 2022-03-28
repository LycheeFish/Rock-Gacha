using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckCUREL : MonoBehaviour
{

    public PremiumCurrencyNU curCU;
    public PremiumCurrencyRE curRE;
    public PremiumCurrencyL curL;

    public Slider mainSlider;
    public TheDictionary listofValues;

    public int id;

    void Update()
    {

        id = int.Parse(GameObject.Find("IDDes").GetComponent<TextMeshProUGUI>().text);
    }


    //check if common, uncommon, rare, epic or legendary and call function to sell
    public void checkInventoryNumber()
    {
        if ((GameObject.Find("RarityDes").GetComponent<TextMeshProUGUI>().text) == "Common" || (GameObject.Find("RarityDes").GetComponent<TextMeshProUGUI>().text) == "Uncommon")
        {
            sellCU();
        }
        else if ((GameObject.Find("RarityDes").GetComponent<TextMeshProUGUI>().text) == "Rare" || (GameObject.Find("RarityDes").GetComponent<TextMeshProUGUI>().text) == "Epic")
        {
            sellRE();
        }
        else if ((GameObject.Find("RarityDes").GetComponent<TextMeshProUGUI>().text) == "Legendary")
        {
            sellL();
        }
    }

    public void sellCU()
    {
        listofValues.countDict[id] -= (int)mainSlider.value;
        curCU.numCurrencyNU += (int)mainSlider.value;
    }

    public void sellRE()
    {
        listofValues.countDict[id] -= (int)mainSlider.value;
        curRE.numCurrencyRE += (int)mainSlider.value;
    }

    public void sellL()
    {
        listofValues.countDict[id] -= (int)mainSlider.value;
        curL.numCurrencyL += (int)mainSlider.value;
    }
}
