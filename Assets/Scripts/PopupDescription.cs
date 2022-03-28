using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopupDescription : MonoBehaviour
{

    public Button thisButton;
    public TextMeshProUGUI Name;
    public TextMeshProUGUI rarity;
    public TextMeshProUGUI description;
    public TextMeshProUGUI id;
    public Image itemImage;
    public Canvas DescriptionCanvas;
    public InventorySlot currentSlot;



    // Start is called before the first frame update
    void Start()
    {
        thisButton = gameObject.GetComponent<Button>();
        thisButton.onClick.AddListener(ChangeDescription);

        GameObject temp1 = GameObject.Find("NameDes");
        Name = temp1.GetComponent<TextMeshProUGUI>();

        GameObject temp2 = GameObject.Find("RarityDes");
        rarity = temp2.GetComponent<TextMeshProUGUI>();

        GameObject temp3 = GameObject.Find("DescriptionDes");
        description = temp3.GetComponent<TextMeshProUGUI>();

        GameObject temp4 = GameObject.Find("ImageDes");
        itemImage = temp4.GetComponent<Image>();

        GameObject temp5 = GameObject.Find("IDDes");
        id = temp5.GetComponent<TextMeshProUGUI>();

    }


    public void ChangeDescription()
    {

        Name.text = gameObject.GetComponent<InventorySlot>().itemName;
        rarity.text = gameObject.GetComponent<InventorySlot>().rarity;
        description.text = gameObject.GetComponent<InventorySlot>().description;
        itemImage.sprite = gameObject.GetComponent<InventorySlot>().itemImage.sprite;
        id.text = "" + gameObject.GetComponent<InventorySlot>().id;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
