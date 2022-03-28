using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//hello

public class Popup : MonoBehaviour
{
    public Canvas canvasOne;
    public Canvas canvasTen;
    public Canvas rejectionCanvas;
    public SummonCost money;
    public SummonCost moneyTen;
    public CurrencyInventory inventory;
    public GachaSystem lootTable;
    public GachaSystem lootTableNU;
    public GachaSystem lootTableRE;
    public GachaSystem lootTableL;

    public bool a = false;
    private InventoryItem result;
    private InventoryItem resultTen;
    public ItemHolder itemHeld;
    public TenItemHolder tenItemHeld;
    public TheDictionary dictionary;

    public PremiumCurrencyNU PCNU;
    public PremiumCurrencyRE PCRE;
    public PremiumCurrencyL PCL;



    public void SellforNUone(Canvas canvasname)
    {
        if (PCNU.numCurrencyNU >= 1)
        {
            PCNU.numCurrencyNU -= 1;
            Pop(canvasname);
            result = lootTableNU.GetDrop();
            itemHeld.item = result;
            dictionary.countDict[result.ID]++;

        }
        
    }

    public void SellforNUten(Canvas canvasname)
    {
        if (PCNU.numCurrencyNU >= 10)
        {
            PCNU.numCurrencyNU -= 10;
            Pop(canvasname);
            for (int i = 0; i < 10; i++)
            {
                resultTen = lootTableNU.GetDrop();
                tenItemHeld.tenSummon[i] = resultTen;
                dictionary.countDict[resultTen.ID]++;
            }
            //lootTable.GetDrop();
        }
    }

    public void SellforREone(Canvas canvasname)
    {
        if (PCRE.numCurrencyRE >= 1)
        {
            PCRE.numCurrencyRE -= 1;
            Pop(canvasname);
            result = lootTableRE.GetDrop();
            itemHeld.item = result;
            dictionary.countDict[result.ID]++;

        }
    }

    public void SellforREten(Canvas canvasname)
    {
        if (PCRE.numCurrencyRE >= 10)
        {
            PCRE.numCurrencyRE -= 10;
            Pop(canvasname);
            for (int i = 0; i < 10; i++)
            {
                resultTen = lootTableRE.GetDrop();
                tenItemHeld.tenSummon[i] = resultTen;
                dictionary.countDict[resultTen.ID]++;
            }
            //lootTable.GetDrop();
        }
    }

    public void SellforLone(Canvas canvasname)
    {
        if (PCL.numCurrencyL >= 1)
        {
            PCL.numCurrencyL -= 1;
            Pop(canvasname);
            result = lootTableL.GetDrop();
            itemHeld.item = result;
            dictionary.countDict[result.ID]++;

        }
    }

    public void SellforLten(Canvas canvasname)
    {
        if (PCL.numCurrencyL >= 10)
        {
            PCL.numCurrencyL -= 10;
            Pop(canvasname);
            for (int i = 0; i < 10; i++)
            {
                resultTen = lootTableL.GetDrop();
                tenItemHeld.tenSummon[i] = resultTen;
                dictionary.countDict[resultTen.ID]++;
            }
            //lootTable.GetDrop();
        }
    }


    public void Pop(Canvas canvasname)
    {
        if (a == false)
        {
            a = true;
            canvasname.enabled = true;
        }
        else if (a == true)
        {
            a = false;
            canvasname.enabled = false;
        }
    }

    public void Rejection(Canvas rejectionletter)
    {
        if (a == false)
        {
            a = true;
            rejectionletter.enabled = true;
        }
        else if (a == true)
        {
            a = false;
            rejectionletter.enabled = false;
        }
    }

    public void CheckOne(Canvas canvasname)
    {
        if (inventory.numberofcurrency >= money.cost)
        {
            inventory.numberofcurrency -= money.cost;
            Pop(canvasname);
            result = lootTable.GetDrop();
            itemHeld.item = result;
            dictionary.countDict[result.ID]++;


        }

    }

    public void CheckOneRejection(Canvas rejectionCanvas)
    {
        if (inventory.numberofcurrency < money.cost)
        {
            Rejection(rejectionCanvas);
        }
    }

    public void CheckTen(Canvas canvasname)
    {
        if (inventory.numberofcurrency >= moneyTen.costTen)
        {
            inventory.numberofcurrency -= moneyTen.costTen;
            Pop(canvasname);
            for (int i = 0; i < 10; i++)
            {
                resultTen = lootTable.GetDrop();
                tenItemHeld.tenSummon[i] = resultTen;
                dictionary.countDict[resultTen.ID]++;
            }
            //lootTable.GetDrop();
        }

    }

    public void CheckTenRejection(Canvas rejectionCanvas)
    {
        if (inventory.numberofcurrency < moneyTen.costTen)
        {
            Rejection(rejectionCanvas);
        }
    }

    public void CheckOneNURejection(Canvas rejectionCanvas)
    {
        if (PCNU.numCurrencyNU < 1)
        {
            Rejection(rejectionCanvas);
        }
    }

    public void CheckOneRERejection(Canvas rejectionCanvas)
    {
        if (PCRE.numCurrencyRE < 1)
        {
            Rejection(rejectionCanvas);
        }
    }

    public void CheckOneLRejection(Canvas rejectionCanvas)
    {
        if (PCL.numCurrencyL < 1)
        {
            Rejection(rejectionCanvas);
        }
    }

    public void CheckTenNURejection(Canvas rejectionCanvas)
    {
        if (PCNU.numCurrencyNU < 10)
        {
            Rejection(rejectionCanvas);
        }
    }

    public void CheckTenRERejection(Canvas rejectionCanvas)
    {
        if (PCRE.numCurrencyRE < 10)
        {
            Rejection(rejectionCanvas);
        }
    }

    public void CheckTenLRejection(Canvas rejectionCanvas)
    {
        if (PCL.numCurrencyL < 10)
        {
            Rejection(rejectionCanvas);
        }
    }
}