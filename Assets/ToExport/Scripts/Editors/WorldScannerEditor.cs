using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace EthanMoody
{
    [CustomEditor(typeof(WorldScanner), true)]
    public class WorldScannerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("Scan World"))
            {
                WorldScanner worldScanner;
                worldScanner = target as WorldScanner;
                worldScanner?.ScanWorld();
            }
        }
    }
}

