using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Specialized;

public class CanvasScroll : MonoBehaviour
{


    public GameObject[] rightScroll;
    public GameObject[] leftScroll;

    public Canvas canvasOne;
    public Canvas canvasTwo;
    public Canvas canvasThree;
    public Canvas canvasFour;


    public int currentCanvas;

    public Dictionary<string, Canvas> open = new Dictionary<string, Canvas>();


    // Start is called before the first frame update
    void Awake()
    {
        rightScroll = GameObject.FindGameObjectsWithTag("ScrollRight");
        leftScroll = GameObject.FindGameObjectsWithTag("ScrollLeft");

        foreach (GameObject obj in rightScroll)
        {
            obj.GetComponent<Button>().onClick.AddListener(ScrollRight);
        }
        foreach (GameObject obj in leftScroll)
        {
            obj.GetComponent<Button>().onClick.AddListener(ScrollLeft);
        }

        currentCanvas = 0;



        open.Add("0", canvasOne);
        open.Add("1", canvasTwo);
        open.Add("2", canvasThree);
        open.Add("3", canvasFour);


        canvasOne.enabled = true;

        for (int i = 1; i < open.Count; i++)
        {
            open["" + i].GetComponent<Canvas>().enabled = false;
        }



    }



    public void ScrollRight()
    {
        open["" + currentCanvas].GetComponent<Canvas>().enabled = false;
        open["" + (currentCanvas + 1)].GetComponent<Canvas>().enabled = true;
        currentCanvas++;
    }

    public void ScrollLeft()
    {
        open["" + currentCanvas].GetComponent<Canvas>().enabled = false;
        open["" + (currentCanvas - 1)].GetComponent<Canvas>().enabled = true;
        currentCanvas--;
    }

    // Update is called once per frame
    void Update()
    {


        switch (currentCanvas)
        {
            case 0:
                foreach (GameObject obj in leftScroll)
                {
                    obj.GetComponent<Button>().interactable = false;
                }
                break;

            case 1:
                foreach (GameObject obj in leftScroll)
                {
                    obj.GetComponent<Button>().interactable = true;
                }
                break;

            case 2:
                foreach (GameObject obj in rightScroll)
                {
                    obj.GetComponent<Button>().interactable = true;
                }
                break;

            case 3:
                foreach (GameObject obj in rightScroll)
                {
                    obj.GetComponent<Button>().interactable = false;
                }
                break;

            default:
                break;
        }
    }
}