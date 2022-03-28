using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public TheDictionary dictionary;
    [SerializeField] private GameObject blankInventorySlot;
    [SerializeField] private GameObject inventoryPanel;
    private Vector3 scale;
    private void Awake()
    {
        scale = new Vector3(2.597403f, 2.597403f, 2.597403f);
    }

    void MakeInventorySlots()
    {
        if (playerInventory)
        {
            for (int i = 0; i < playerInventory.Inventory.Count; i++)
            {
                if (dictionary.countDict[playerInventory.Inventory[i].ID] > 0)
                {
                    GameObject temp = Instantiate(blankInventorySlot, inventoryPanel.transform.position, Quaternion.identity);
                    temp.transform.SetParent(inventoryPanel.transform);
                    InventorySlot newSlot = temp.GetComponent<InventorySlot>();
                    newSlot.transform.localScale = scale;
                    if (newSlot)
                    {
                        newSlot.Setup(playerInventory.Inventory[i], this);
                        newSlot.gameObject.AddComponent<PopupDescription>();
                        newSlot.gameObject.AddComponent<CreateDesCanvas>();
                        newSlot.gameObject.AddComponent<ChangeSellNum>();
                    }
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        MakeInventorySlots();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
