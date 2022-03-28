using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateDesCanvas : MonoBehaviour
{
    public Button thisButton;
    public Canvas descCanvas;
    

    void Start()
    {
        GameObject temp = GameObject.Find("CanvasOfDescriptions");
        descCanvas = temp.GetComponent<Canvas>();

        thisButton = gameObject.GetComponent<Button>();

        thisButton.onClick.AddListener(delegate { Pop(descCanvas); });

    }

    public void Pop(Canvas canvasname)
    {
        canvasname.enabled = true;
    }
}
