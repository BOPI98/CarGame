using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlDisable : MonoBehaviour
{
    public GameObject CarControl1;
    public GameObject CarControl2;

    void Start()
    {
        CarControl1.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = false;
        CarControl2.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = false;
        CarControl1.GetComponent<UnityStandardAssets.Vehicles.Car.CarUserControl>().enabled = false;
        CarControl2.GetComponent<UnityStandardAssets.Vehicles.Car.CarAIControl>().enabled = false;
    }

}
