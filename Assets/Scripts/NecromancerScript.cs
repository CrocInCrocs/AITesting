using System.Collections;
using System.Collections.Generic;
using Anthill.AI;
using UnityEngine;
public enum NecromancerAI
{
    attackingPlayer = 0,
    seePlayer = 1,
    hasSoldiers = 2,
    allyDead = 3,
    shielding = 4,
    playerClose = 5
}
public class NecromancerScript : MonoBehaviour, ISense
{
    public NecromancerModel modelNecromancer;
    public bool attackingPlayer;
    public bool seePlayer;
    public bool hasSoldier;
    public bool allyDead;
    public bool shielding;
    public bool playerClose;

    public void CollectConditions(AntAIAgent aAgent, AntAICondition aWorldState)
    {
        aWorldState.Set(NecromancerAI.attackingPlayer, attackingPlayer);
        aWorldState.Set(NecromancerAI.seePlayer, seePlayer);
        aWorldState.Set(NecromancerAI.hasSoldiers, modelNecromancer.HasSoldier());
        aWorldState.Set(NecromancerAI.allyDead, allyDead);
        aWorldState.Set(NecromancerAI.shielding, shielding);
        aWorldState.Set(NecromancerAI.playerClose, playerClose);

    }
}
