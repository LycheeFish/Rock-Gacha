using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public TextMeshProUGUI itemNumberText;
    public Image itemImage;
    public string rarity;
    public string description;
    public string itemName;
    public int id;

    

    public InventoryItem thisItem;
    public InventoryManager thisManager;
    public TheDictionary dictionary;

    // Start is called before the first frame update
    public void Setup(InventoryItem newItem, InventoryManager newManager)
    {
        thisItem = newItem;
        thisManager = newManager;
        if (thisItem)
        {
            itemImage.sprite = thisItem.imageName;
            itemNumberText.text = "" + dictionary.countDict[thisItem.ID];
            rarity = thisItem.rarity;
            description = thisItem.Description;
            itemName = thisItem.Name;
            id = thisItem.ID;
        }
    }



    // Update is called once per frame
    void Update()
    {
        itemNumberText.text = "" + dictionary.countDict[thisItem.ID];
    }
}
