using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinding : MonoBehaviour
{
    public Vector3Int size;
    public LayerMask layerMask;

    public Node[,] gridOfObstacles;
    // Start is called before the first frame update
    void Start()
    {
        gridOfObstacles = new Node[size.x,size.z];
    }

    // Update is called once per frame
    void Update()
    {
        ScanWorld();
        
    }

    void ScanWorld()
    {
        for (int x = 0; x < size.x; x++)
        {
            for (int z = 0; z < size.z; z++)
            {
                gridOfObstacles[x, z] = new Node();
                if (Physics.CheckBox(new Vector3(x, 0, z),
                        new Vector3(0.5f, 10f, 0.5f), Quaternion.identity))
                {
// Something is there
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
                else
                {
                    Gizmos.color = Color.green;
                }
                Gizmos.DrawCube(new Vector3(x, 0, z), Vector3.one);
            }
        }
    }


}
