using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Hello
public class CameraMover : MonoBehaviour
{
    #region Public Members

    public enum e_TiltStates
    {
        INVALID = -1,
        IDLE,
        TILTLEFT,
        TILTRIGHT,
        TILTUP,
        TILTDOWN,
        MAX
    };
    public e_TiltStates m_TiltStates = e_TiltStates.IDLE;

    #endregion

    #region Public void

    #endregion

    #region System


    void Start ()
    {

	}
	
	void Update ()
    {
        MoveCamera();
        MoveCameraVertically();
        GetTilt();
        CheckTilt();
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    private void MoveCamera()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal") * cameraRush, 0f, Input.GetAxis("Vertical") * cameraRush);
        }
        else
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        }
    }

    private void MoveCameraVertically()
    {
        if (Input.GetKey(KeyCode.O))
        {
            transform.position += new Vector3(0f, 1f, 0f);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.position += new Vector3(0f, -1f, 0f);
        }
    }

    private void GetTilt()
    {
        if (Input.GetKey(KeyCode.Keypad4)) m_TiltStates = e_TiltStates.TILTUP;
        if (Input.GetKey(KeyCode.Keypad6)) m_TiltStates = e_TiltStates.TILTDOWN;
        if (Input.GetKey(KeyCode.Keypad8)) m_TiltStates = e_TiltStates.TILTLEFT;
        if (Input.GetKey(KeyCode.Keypad2)) m_TiltStates = e_TiltStates.TILTRIGHT;

//        bool tiltLeft   = Input.GetKey(KeyCode.Alpha4);
//        bool tiltRight  = Input.GetKey(KeyCode.Alpha6);
//        bool tiltUp     = Input.GetKey(KeyCode.Alpha8);
//        bool tiltDown   = Input.GetKey(KeyCode.Alpha2);
        CheckTilt();
    }

    private void CheckTilt()
    {
        switch (m_TiltStates)
        {
            case e_TiltStates.IDLE:
                break;

            case e_TiltStates.TILTLEFT:
                transform.Rotate(Vector3.left);
                m_TiltStates = e_TiltStates.IDLE;
                break;

            case e_TiltStates.TILTRIGHT:
                transform.Rotate(Vector3.right);
                m_TiltStates = e_TiltStates.IDLE;
                break;

            case e_TiltStates.TILTUP:
                transform.Rotate(Vector3.up);
                m_TiltStates = e_TiltStates.IDLE;
                break;

            case e_TiltStates.TILTDOWN:
                transform.Rotate(Vector3.down);
                m_TiltStates = e_TiltStates.IDLE;
                break;
        }
    }

    private int cameraRush = 10;

    #endregion
}
