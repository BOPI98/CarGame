using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Countdown : MonoBehaviour
{

    public GameObject LapTimer;
    public GameObject CarControls;

    void Start() {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        this.gameObject.GetComponent<Text>().text = "3";
        this.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);

        this.gameObject.GetComponent<Text>().text = "2";
        
        yield return new WaitForSeconds(1);

        this.gameObject.GetComponent<Text>().text = "1";
        
        yield return new WaitForSeconds(1);

        this.gameObject.GetComponent<Text>().text = "GO!";
        
        LapTimer.SetActive(true);
        CarControls.SetActive(true);
        yield return new WaitForSeconds(1);
        this.gameObject.SetActive(false);
    }
    
}
