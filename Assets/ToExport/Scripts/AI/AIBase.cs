using System.Collections;
using System.Collections.Generic;
using Anthill.AI;
using UnityEngine;
using UnityEngine.Serialization;

public enum AIBehaviours
{
    attackingPlayer = 0,
    seePlayer = 1,
    hasSoldiers = 2,
    allyDead = 3,
    shielding = 4,
    playerClose = 5
}
public class AIBase : MonoBehaviour, ISense
{
    public AIModel modelAI;
    public bool attackingPlayer;
    public bool seePlayer;
    public bool hasSoldier;
    public bool allyDead;
    public bool shielding;
    public bool playerClose;

    public void CollectConditions(AntAIAgent aAgent, AntAICondition aWorldState)
    {
        aWorldState.Set(AIBehaviours.attackingPlayer, attackingPlayer);
        aWorldState.Set(AIBehaviours.seePlayer, seePlayer);
        aWorldState.Set(AIBehaviours.hasSoldiers, modelAI.HasSoldier());
        aWorldState.Set(AIBehaviours.allyDead, allyDead);
        aWorldState.Set(AIBehaviours.shielding, shielding);
        aWorldState.Set(AIBehaviours.playerClose, playerClose);

    }
}
