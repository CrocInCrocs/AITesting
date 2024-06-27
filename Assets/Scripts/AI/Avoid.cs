using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Avoid : MonoBehaviour
{
  public LayerMask layerMask;
  public Rigidbody mainBody;
  public float rayDistance;
  
  public void FixedUpdate()
  {
    RaycastHit hitInfo;
    bool raycast = Physics.Raycast(mainBody.transform.position, mainBody.transform.forward, out hitInfo, rayDistance);
  }
}
