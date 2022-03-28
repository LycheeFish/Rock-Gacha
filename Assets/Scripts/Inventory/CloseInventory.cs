using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseInventory : MonoBehaviour
{

    public Button thisButton;
    public Canvas descCanvas;
    

    void Start()
    {
        

        thisButton.onClick.AddListener(delegate { Pop(descCanvas); });

    }

    public void Pop(Canvas canvasname)
    {
        canvasname.enabled = false;
    }
}
