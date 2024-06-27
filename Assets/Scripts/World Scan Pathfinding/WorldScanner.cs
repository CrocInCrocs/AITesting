using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class WorldScanner : MonoBehaviour
{
    public Vector3Int size;
    public LayerMask layerMask;

    public Node[,] gridOfObstacles;

    public Fill fill;
    // Start is called before the first frame update
    void Awake()
    {
        gridOfObstacles = new Node[size.x,size.z];
        
        ScanWorld();
    }
    
    // Update is called once per frame
    void Update()
    {
        //ScanWorld();
    }

    public void ScanWorld()
    {
        for (int x = 0; x < size.x; x++)
        {
            for (int z = 0; z < size.z; z++)
            {
                gridOfObstacles[x, z] = new Node();
                gridOfObstacles[x, z].x = x;
                gridOfObstacles[x, z].z = z;
                if (Physics.CheckBox(new Vector3(x, 0, z),
                        new Vector3(0.5f, 10f, 0.5f), Quaternion.identity, layerMask))
                {
                    gridOfObstacles[x, z].isBlocked = true;
                }
            }
        }
    }
    
     void OnDrawGizmos()
    {
        for (int x = 0; x < size.x; x++)
        {
            for (int z = 0; z < size.z; z++)
            {
                if (gridOfObstacles != null && gridOfObstacles[x, z].isBlocked)
                {
                    Gizmos.color = Color.red;
                   
                }
                else if (gridOfObstacles != null && fill.open.Contains(gridOfObstacles[x,z]))
                {
                    Gizmos.color = Color.cyan;
                }
                else if (gridOfObstacles != null && fill.closed.Contains(gridOfObstacles[x, z]))
                {
                    Gizmos.color = Color.grey;
                }
                else
                {
                    Gizmos.color = Color.green;
                }
                Gizmos.DrawCube(new Vector3(x, 0, z), Vector3.one);
            }
        }
    }
}
