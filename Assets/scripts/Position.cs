using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Position : MonoBehaviour
{

    public GameObject PlayerProgress;
    public GameObject AIProgress;


    public float a ;
    public float b ;

    public void Start()
    {
        Debug.Log(" startasd ");
    }

    // Update is called once per frame
    public void Update()
    {
        a = Convert.ToSingle(PlayerProgress.GetComponent<Text>().text);
        b = Convert.ToSingle(AIProgress.GetComponent<Text>().text);
        Debug.Log("  " + a + "  ");
        Debug.Log("  " + b + "  ");
        
        if (a > b)
        {
            this.GetComponent<Text>().text = ""+"1";

        }
        else if(a < b)
        {
            this.GetComponent<Text>().text = ""+"2";
        }
    }
}
