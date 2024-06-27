using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fill : MonoBehaviour
{
    public Vector3Int currentPosition;
    public Node currentNode;
    public List<Node> open;
    public List<Node> closed;
    public float waitTime;

    public WorldScanner worldScanner;
    // Start is called before the first frame update
    void Start()
    {
       open.Add(worldScanner.gridOfObstacles[0, 0]);
    }

    public void StartWorldFill()
    {
        StartCoroutine(WorldFill());
    }
    
    public IEnumerator WorldFill()
    {
        while (open.Count > 0)
        {
            for (int currentNodeIndex = open.Count-1; currentNodeIndex >= 0; currentNodeIndex--)
            {
                currentPosition = new Vector3Int(open[currentNodeIndex].x, 0, open[currentNodeIndex].z);
                if (!open.Contains(worldScanner.gridOfObstacles[currentPosition.x,currentPosition.z])) open.Add(worldScanner.gridOfObstacles[currentPosition.x,currentPosition.z]);
                
                for (int xOffset  = -1; xOffset  < 2; xOffset++)
                {
                    for (int zOffset = -1; zOffset < 2; zOffset++)
                    {
                        if(currentPosition.x + xOffset >= 0 && currentPosition.x - xOffset <= worldScanner.size.x && currentPosition.z + zOffset >= 0 && currentPosition.z - zOffset <= worldScanner.size.z) // Valid
                        {
                            Node neighbourNode = worldScanner.gridOfObstacles[currentPosition.x + xOffset, currentPosition.z + zOffset];
                            if (!neighbourNode.isBlocked && !open.Contains(neighbourNode) && !closed.Contains(neighbourNode))
                            {
                                open.Add(neighbourNode);
                            }
                        }
                    }
                }
                closed.Add(open[currentNodeIndex]);

                yield return new WaitForSeconds(waitTime);
                
                open.Remove(open[currentNodeIndex]);
                
                yield return new WaitForSeconds(waitTime);
            }
            continue;
            
        }
    }
}
