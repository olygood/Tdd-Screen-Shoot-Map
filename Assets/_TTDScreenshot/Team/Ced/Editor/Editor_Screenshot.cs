using System.Collections;
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

        CreateListOnInspector();
        SaveThePosition();

        if (GUILayout.Button("Renderer"))
        {
            Debug.Log("Renderer");
        }
    }

    private void CreateListOnInspector()
    {
        GUILayout.BeginHorizontal();
            GUILayout.Label("x: ");
        GUILayout.EndHorizontal();
    }

    private void SaveThePosition()
    {
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
