using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public abstract void DoMovement();

    private void Update()
    {
        DoMovement();
    }
}
