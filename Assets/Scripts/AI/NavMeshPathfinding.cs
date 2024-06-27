using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshPathfinding : MonoBehaviour
{
    private NavMeshPath path;
    public Transform targetPoint;

    // Start is called before the first frame update
    void Awake()
    {
        path = new NavMeshPath();
    }

    // Update is called once per frame
    void Update()
    {
        NavMesh.CalculatePath(transform.position, targetPoint.position, NavMesh.AllAreas, path);

    }

    private void OnDrawGizmos()
    {
        if (path != null)
        {
            for (int index = 0; index < path.corners.Length -1 ; index++)
            {
                Gizmos.DrawLine(path.corners[index], path.corners[index+1]);
                Gizmos.color = Color.green;
            }
        }
    }
}
