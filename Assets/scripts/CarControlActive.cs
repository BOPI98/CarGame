using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlActive : MonoBehaviour
{
    public GameObject CarControl1;
    public GameObject CarControl2;

    // Start is called before the first frame update
    void Start()
    {
        
            CarControl1.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
            CarControl2.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
        
    }

    
}
