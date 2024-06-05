using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.WSA;

public class Wander : MonoBehaviour
{
    public float perlin;
    public Rigidbody body;
    public float perlinOffset;

    // Update is called once per frame
    void FixedUpdate()
    {
        perlin = Mathf.PerlinNoise1D(Time.time);
        perlinOffset = (perlin * 2f) - 1f;
        
        body.AddRelativeTorque(0,(perlinOffset - 0.1f),0);
        
    }
}
