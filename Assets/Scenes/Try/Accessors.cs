using System;
using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using UnityEngine;

public class Accessors : Shape, ITry
{
   public Properties _properties = new Properties(10,10);

   private void Start()
   {
      _properties.Donut = 20;
      _properties.GetHealth = 30;
      print("Donut = " + _properties.Donut + "Health = " + _properties.GetHealth );
   }


   public void DoThing(int a)
   {
      
   }

   public override void DoMovement()
   {
      transform.Translate(Vector3.forward * (Time.deltaTime * 10));
   }
}
