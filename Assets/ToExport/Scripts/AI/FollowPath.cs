using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EthanMoody
{
    public class FollowPath : MonoBehaviour
    {
        public NavMeshPathfinding navMesh;
        public int index;
        public TurnTowards turnTowards;
        public float distance;
        // Start is called before the first frame update
        void Start()
        {
      
        }

        // Update is called once per frame
        void Update()
        {
            distance = (transform.position - navMesh.path.corners[index]).magnitude;
            turnTowards.target.position = navMesh.path.corners[index];
            Debug.DrawLine(transform.position, navMesh.path.corners[index]);
            if (distance <= 2f)
            {
                index++;
           
            }
        }
    }
}

