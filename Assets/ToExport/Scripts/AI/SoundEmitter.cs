using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EthanMoody
{
    public class SoundEmitter : MonoBehaviour
    {
        public Hearing hearing;
        public List<GameObject> listeners;
        public float radius;

        /*public void EmitSound()
        {
            Physics.OverlapSphere(transform.position, radius);
            foreach (var soundHeard in listeners)
            {
                if (GetComponent<Hearing>().HeardSomething(hearing.soundHeard) == true)
                {

                }
            }
        }*/
    }
}

