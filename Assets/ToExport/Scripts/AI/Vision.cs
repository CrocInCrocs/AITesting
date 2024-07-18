using System;
using System.Collections;
using System.Collections.Generic;
using Tanks;
using UnityEditor.PackageManager;
using UnityEngine;

namespace EthanMoody
{
    public class Vision : MonoBehaviour
    {
        public Rigidbody body;
        public float maxAngle = 100f;
        public int rays = 10;
        public List<GameObject> thingsSeen;
    
        // Update is called once per frame
        void FixedUpdate()
        {
            Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, Int32.MaxValue, 255,
                QueryTriggerInteraction.Ignore);

            float currentAngle = -maxAngle / 2f;

            for (int i = 0; i < rays; i++)
            {
                Vector3 dir = Quaternion.Euler(0, currentAngle, 0) * transform.forward;

                float spreadAngle = maxAngle / (rays - 1);
                currentAngle += spreadAngle;
            }

        
        }
    }
}

