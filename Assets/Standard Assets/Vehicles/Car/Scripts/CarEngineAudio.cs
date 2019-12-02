using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class CarEngineAudio : MonoBehaviour
{
    // Start is called before the first frame update
    FMOD.Studio.EventInstance EngineTotal;
    FMOD.Studio.EventInstance RPM;
    FMOD.Studio.EventInstance Load;
 
    CarController carController;

    void Awake()
    {
        EngineTotal = FMODUnity.RuntimeManager.CreateInstance("event:/EngineTotal");
        //EngineTotal.getParameterByName("RPM", out RPM);
        carController = GetComponent<CarController>();
    }
    void Start()
    {
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(EngineTotal, GetComponent<Transform>(), GetComponent<Rigidbody>());
        EngineTotal.start();
    }

    // Update is called once per frame
    void Update()
    {
        RPM.setParameterByName("RPM", carController.Revs);
        Load.setParameterByName("Load", carController.AccelInput);
    }
}
