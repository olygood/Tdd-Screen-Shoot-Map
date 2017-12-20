using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SceneViewCamera : EditorWindow
{
    [MenuItem("Window/SceneViewCamera")]
    static void Init()
    {
        SceneViewCamera window = (SceneViewCamera)EditorWindow.GetWindow(typeof(SceneViewCamera));
    }

    private void OnGUI()
    {
        EditorGUILayout.TextField("SceneViewCameraAngle", "" + SceneView.lastActiveSceneView.rotation);
        EditorGUILayout.TextField("SceneViewCameraPosition", "" + SceneView.lastActiveSceneView.camera.transform.position);

    }
    
}
