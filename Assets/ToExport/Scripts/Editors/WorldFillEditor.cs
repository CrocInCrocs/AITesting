using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.TerrainTools;
using UnityEngine;

namespace EthanMoody
{
    [CustomEditor(typeof(Fill),true)]
    public class WorldFillEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("World Fill"))
            {
                Fill fill;
                fill = target as Fill;
                fill?.StartWorldFill();
            }
        }
    }
}

