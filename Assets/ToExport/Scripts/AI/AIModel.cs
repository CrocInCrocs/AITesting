using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIModel : MonoBehaviour
{
    public AIBase necromancer;
    public int army;

    public bool HasSoldier()
    {
        if (army < 1)
        {
            return necromancer.hasSoldier = false;
        }
        else
        {
            return necromancer.hasSoldier = true;
        }
    }

    public void FixedUpdate()
    {
        if (necromancer.allyDead == true && army < 50)
        {
            StartCoroutine(ArmyIncrease());
            Debug.Log("Revived ally");
        }
        else if (army > 50)
        {
            army = 50;
        }
    }

    public IEnumerator ArmyIncrease()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.5f);
            army =+ 1;
        }
       
    }
    
    
}
