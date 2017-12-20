using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Screenshot))]
public class Editor_Screenshot : Editor
{
    public override void OnInspectorGUI()
    {
        rot = SceneView.lastActiveSceneView.rotation;
        pos = SceneView.lastActiveSceneView.camera.transform.position;

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
        foreach(CameraSnap snap in m_cameraSnap)
        {
            GUILayout.BeginHorizontal();
                GUILayout.Label("x: " + snap.cameraVect.x, GUILayout.Width(50));
                GUILayout.Label("y: " + snap.cameraVect.y, GUILayout.Width(50));
                GUILayout.Label("z: " + snap.cameraVect.z, GUILayout.Width(50));
            GUILayout.EndHorizontal();
        }
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
                m_cameraSnap.Add(new CameraSnap(rot,pos));
            }
        GUILayout.EndHorizontal();
    }

    public class CameraSnap
    {
        public Quaternion cameraQuat;
        public Vector3 cameraVect;

        public CameraSnap(Quaternion _quat, Vector3 _vect)
        {
            cameraQuat = _quat;
            cameraVect = _vect;
        }
    }

    private static List<CameraSnap> m_cameraSnap = new List<CameraSnap>();
    private Quaternion rot;
    private Vector3 pos;
}
