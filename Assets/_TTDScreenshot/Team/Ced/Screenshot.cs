using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Auto-Screenshot/Screenshot")]
public class Screenshot : MonoBehaviour
{
    [SerializeField]
    protected Transform m_position;

    private void Awake()
    {
        m_position = GetComponent<Transform>();
    }
}
