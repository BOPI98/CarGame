
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;
    public GameObject LapCount;
    public GameObject FinishLabel;
    public GameObject CarDisable;
    public GameObject Pos;

    public static int Laps=1;

    public static int min = 59, sec = 59, mil = 9;

    void Update()
    {
        Debug.Log("TIME   "+LapTimeManager.MinuteCount * 600 + LapTimeManager.SecondCount * 10 + Convert.ToInt32(LapTimeManager.MilliCount)+
            " >? " + min * 600 + sec * 10 + mil);
    }

    void OnTriggerEnter(Collider carcollision)
    {
        if (carcollision.gameObject.tag == "Player")
        {
            if (LapTimeManager.MinuteCount*600+LapTimeManager.SecondCount*10+Convert.ToInt32(LapTimeManager.MilliCount)<
                min*600+sec*10+mil )
            {
                min = LapTimeManager.MinuteCount;
                sec = LapTimeManager.SecondCount;
                mil = Convert.ToInt32(LapTimeManager.MilliCount);
                if (LapTimeManager.MinuteCount <= 9)
                {
                    MinuteDisplay.GetComponent<Text>().text = "0"+LapTimeManager.MinuteCount ;

                }
                else
                {
                    MinuteDisplay.GetComponent<Text>().text = ""+LapTimeManager.MinuteCount;
                }

                if (LapTimeManager.SecondCount <= 9)
                {
                    SecondDisplay.GetComponent<Text>().text = "0"+ LapTimeManager.SecondCount;

                }
                else
                {
                    SecondDisplay.GetComponent<Text>().text =""+ LapTimeManager.SecondCount ;

                }

                MilliDisplay.GetComponent<Text>().text = ""+Convert.ToInt32(LapTimeManager.MilliCount);

            }

            if (Laps == 3)
            {
                if (Pos.GetComponent<Text>().text == "1")
                {
                    FinishLabel.GetComponent<Text>().text = "WINNER!!\nGGEZ";
                }
                else FinishLabel.GetComponent<Text>().text = "Finished!\nat " + Pos.GetComponent<Text>().text + ". place";
                FinishLabel.SetActive(true);
                CarDisable.SetActive(true);
            }
            else
            {
                Laps += 1;
                LapCount.GetComponent<Text>().text = "" + Laps;
            }
            

            LapTimeManager.MinuteCount = 0;
            LapTimeManager.SecondCount = 0;
            LapTimeManager.MilliCount = 0;
            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        }
    }
}
