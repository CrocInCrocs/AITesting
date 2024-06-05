using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   public Rigidbody bodyModel;
   public float speed;
   public Vector3 movement;

   private void FixedUpdate()
   {
      bodyModel.AddRelativeForce(movement);
   }
   
   
}
