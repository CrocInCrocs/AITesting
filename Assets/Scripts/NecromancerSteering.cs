using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecromancerSteering : MonoBehaviour
{
   public Rigidbody bodyModel;
   public float speed;

   private void FixedUpdate()
   {
      bodyModel.AddForce(0f,0,speed);
   }
}
