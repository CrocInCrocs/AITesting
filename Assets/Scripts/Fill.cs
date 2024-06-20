using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fill : MonoBehaviour
{
    public Vector3Int currentPosition;
    public Node currentNode;
    public List<Node> open;
    public List<Node> closed;

    public WorldScanner worldScanner;
    // Start is called before the first frame update
    void Start()
    {
       currentNode = worldScanner.gridOfObstacles[currentPosition.x, currentPosition.z];
        open.Add(currentNode);
    }

    public void StartWorldFill()
    {
        StartCoroutine(WorldFill());
    }
    
    public IEnumerator WorldFill()
    {
        yield return new WaitForSeconds(2);
        
        while (open.Count > 0)
        {
           
            closed.Add(currentNode);
            
            for (int xOffset  = -1; xOffset  < 2; xOffset++)
            {
                for (int zOffset = -1; zOffset < 2; zOffset++)
                {
                    // Find the actual node
                    //open[Random.Range(0, open.Count)];
                    // Check if the coordinate is valid here (might be past the boundary)
		
                    if(currentPosition.x + xOffset >= 0) // Valid
                    {
                        Node neighbourNode = worldScanner.gridOfObstacles[currentPosition.x + xOffset, currentPosition.z + zOffset];
                        if (!neighbourNode.isBlocked && !open.Contains(neighbourNode))
                        {
                            open.Add(neighbourNode);
                        }
                        //Check !isBlocked 
                        //open.Cotains(neighbourNode)
                        // open.Add(neighbourNode)
                        
                    }
                    // Do checks here, before adding node to open/closed lists
                }
            }
            open.Remove(currentNode);
            
        }
    }
}
