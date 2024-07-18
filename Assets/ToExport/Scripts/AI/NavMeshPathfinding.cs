using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace EthanMoody
{
    public class NavMeshPathfinding : MonoBehaviour
    {
        public NavMeshPath path;
        public Transform targetPoint;
        public bool calculate = false;

        // Start is called before the first frame update
        void Awake()
        {
            path = new NavMeshPath();
            CalculatePath();
        }

        // Update is called once per frame
        void Update()
        {
            if (calculate == true)
            {
                CalculatePath();
            }

        }

        private void OnDrawGizmos()
        {
            if (path != null)
            {
                for (int index = 0; index < path.corners.Length -1 ; index++)
                {
                    Gizmos.color = Color.green;
                    Gizmos.DrawLine(path.corners[index], path.corners[index+1]);
                    Gizmos.color = Color.red;
                }
            }
        }

        public void CalculatePath()
        {
            NavMesh.CalculatePath(transform.position, targetPoint.position, NavMesh.AllAreas, path);
        }
    }
}

