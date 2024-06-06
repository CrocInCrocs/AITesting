using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTowards : MonoBehaviour
{
    public Rigidbody body;
    public float yawSpeed;
    public Transform target;
    public Vector3 targetPosition;
    public float angle;
    Vector3 targetDir;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (target)
        {
            targetDir = target.position - transform.position;
        }
        else
        {
            targetDir = targetPosition - transform.position;
        }
        angle = Vector3.SignedAngle(transform.forward, targetDir, Vector3.up);
        body.AddRelativeTorque(0,yawSpeed/angle ,0);

        if (transform.rotation.y == targetDir.y)
        {
             yawSpeed -= 1;
        }
        
    }
}
