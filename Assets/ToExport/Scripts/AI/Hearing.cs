using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EthanMoody
{
    public class Hearing : MonoBehaviour
    {
        public AudioClip lastHeard;

        public void HeardSomething(AudioClip soundHeard)
        {
            lastHeard = soundHeard; 
        }
    }
}

