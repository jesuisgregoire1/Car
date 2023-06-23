using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    // Smoothly rotate an object over time using Slerp
    public float rotationSpeed;
    public Vector3 rotationAxis;
    private Quaternion startPosition;
    private void Start()
    {
        startPosition = transform.rotation;
    }

    private float horizontal = 0f;
    private int endAngle = 30;
    private float startAngle = 0;
    private float angle;
    float count = 0;
    float t = 0;
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") < 0) {
            count += rotationSpeed * Time.deltaTime;
            angle += rotationSpeed * Time.deltaTime;
            angle = Mathf.Clamp(angle, -30, 30);
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            count += rotationSpeed * Time.deltaTime;
            angle -= rotationSpeed * Time.deltaTime;
            angle = Mathf.Clamp(angle, -30, 30);
        }
        else if (Input.GetAxisRaw("Horizontal") == 0)
        {
            count += rotationSpeed * Time.deltaTime;
            if (angle >= 0)
            {
                angle -= rotationSpeed * Time.deltaTime;
                angle = Mathf.Clamp(angle, 0,angle);
            }
            else if(angle <= 0)
            {
                angle += rotationSpeed * Time.deltaTime;
                angle = Mathf.Clamp(angle, angle,0);
            }
        }
        transform.eulerAngles = new Vector3(count, angle, 0);
    }
}
