using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CameraShotEditor : EditorWindow 
{
    public static List<CameraOrientation> _recorderedPosition = new List<CameraOrientation>();

        public class CameraOrientation {
        public Vector3 _position;
        public Quaternion _rotation;
    }

    [MenuItem("Toolbox/Render Screenshot Setting")]
    public static void TakeScreenShotSetting()
    {
        CameraShotEditor window = (CameraShotEditor)EditorWindow.GetWindow(typeof(CameraShotEditor));
        window.Show();

    }
    [MenuItem("Toolbox/Save Position %#_r")]
    public static void SaveEditorCameraPosition()
    {

        Debug.Log("Camera position:" + Camera.main.transform.position+" / "+ Camera.main.transform.rotation);
        _recorderedPosition.Add(new CameraOrientation() { _position = Camera.main.transform.position, _rotation = Camera.main.transform.rotation });
    }
}
