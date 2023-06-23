using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Tires[] wheels;
    
    [Header("Car Specs")] 
    public float wheelBase;
    public float rearTrack;
    public float turnRadius;
    
    [Header("Inputs")] public float steerInput;
    [SerializeField]private float ackermannAngleLeft;
    [SerializeField]private float ackermannAngleRight;

    [SerializeField]private float maxDistance;
    
    public float GetMaxDistance => maxDistance;
    void Update()
    {
        steerInput = Input.GetAxis("Horizontal");
        
        if (steerInput > 0)
        {
            ackermannAngleLeft = Mathf.Rad2Deg * Mathf.Atan(wheelBase / (turnRadius + (rearTrack / 2))) * steerInput;
            ackermannAngleRight = Mathf.Rad2Deg * Mathf.Atan(wheelBase / (turnRadius - (rearTrack / 2))) * steerInput;
        }
        else if (steerInput < 0)
        {
            ackermannAngleLeft = Mathf.Rad2Deg * Mathf.Atan(wheelBase / (turnRadius - (rearTrack / 2))) * steerInput;
            ackermannAngleRight = Mathf.Rad2Deg * Mathf.Atan(wheelBase / (turnRadius + (rearTrack / 2))) * steerInput;
        }
        else if(steerInput == 0)
        {
            ackermannAngleLeft = 0;
            ackermannAngleRight = 0;
        }

        foreach (var wheel in wheels)
        {
            if (wheel.wheelFrontLeft)
                wheel.steerAngle = ackermannAngleLeft;
            if (wheel.wheelFronRigth)
                wheel.steerAngle = ackermannAngleRight;
           
        }
    }
}
