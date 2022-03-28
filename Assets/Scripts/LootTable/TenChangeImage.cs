using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TenChangeImage : MonoBehaviour
{
    public TenItemHolder itemList;
    private Image blankPic;
    public GameObject imageHolder;

    void Update()
    {
        for (int i = 0; i < 10; i++)
        {
           this.gameObject.transform.GetChild(i).GetComponent<Image>().sprite = itemList.tenSummon[i].imageName;
        }
    }
}
