using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
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
