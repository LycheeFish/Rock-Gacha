using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChangeSellNum : MonoBehaviour
{


    public Slider mainSlider;
    public TextMeshProUGUI sellText;
    public TheDictionary listofValues;
    public int id;
    public string idstring;

    // Start is called before the first frame update
    void Start()
    {
        mainSlider = GameObject.Find("SellSlider").GetComponent<Slider>() ;
        sellText = GameObject.Find("SellText").GetComponent<TextMeshProUGUI>();
        id = gameObject.GetComponent<InventorySlot>().id;
        listofValues = Resources.Load<TheDictionary>("theDictionary");
    }

    // Update is called once per frame
    void Update()
    {
        // if ID text of popup is equal to id of the inventory item, set max value of slider to number of that specific inventory item
        if ((GameObject.Find("IDDes").GetComponent<TextMeshProUGUI>().text) == (""+id))
        {
            mainSlider.maxValue = listofValues.countDict[id];
            sellText.text = "Sell " + mainSlider.value;
            Debug.Log(id);
        }
        
    }


}
    