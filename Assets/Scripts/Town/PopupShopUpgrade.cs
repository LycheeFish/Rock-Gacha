using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupShopUpgrade : MonoBehaviour
{
    public Canvas shopOne;
    public Canvas shopTwo;
    public bool a = false;

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
}
