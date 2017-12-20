﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Screenshot))]
public class Editor_Screenshot : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GUILayout.Label("List of position");
        GUILayout.BeginHorizontal();
            GUILayout.Label("x:", GUILayout.Width(20));
            GUILayout.TextField("0", GUILayout.Width(50));
            GUILayout.Label("y:", GUILayout.Width(20));
            GUILayout.TextField("0", GUILayout.Width(50));
            GUILayout.Label("z:", GUILayout.Width(20));
            GUILayout.TextField("0", GUILayout.Width(50));
        if (GUILayout.Button("Save Position"))
            {
                Debug.Log("Save Position");
            }
        GUILayout.EndHorizontal();
    }
}
