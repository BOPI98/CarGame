using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

public class Position : MonoBehaviour
{

    public GameObject PlayerProgress;
    public GameObject AIProgress;


    public static float a;
    public static float b;

    

    // Update is called once per frame
    public void Update()
    {
        a =PlayerProgress.GetComponent<WaypointProgressTracker>().progressDistance;
        b =AIProgress.GetComponent<WaypointProgressTracker>().progressDistance;
        
        
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
