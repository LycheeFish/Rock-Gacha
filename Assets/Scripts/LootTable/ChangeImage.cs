using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeImage : MonoBehaviour
{
    public ItemHolder item;
    public Image blankPic;

    private void Update()
    {
        blankPic.GetComponent<Image>().sprite = item.item.imageName;
        
    }
    

    
}
