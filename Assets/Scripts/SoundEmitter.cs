using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEmitter : MonoBehaviour
{
    public Hearing hearing;
    public float radius;

    public void EmitSound()
    {
        Physics.OverlapSphere(transform.position, radius);
        foreach (var soundHeard in hearing)
        {
            if (GetComponent<Hearing>().HeardSomething(this) == true)
            {
            
            }
        }
    }
}
