using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

//public AudioClip soundScreenShot;
public class Shot : MonoBehaviour
{
  public void TakeScreenShot (){

        //GetComponent<AudioSource> (). PlayOneShot (soundScreenShot);//si j'ai pas ne pas le mettre

        string DT = System.DateTime.Now.ToString (); //renomer le jpg string pas int
        DT = DT.Replace ("/" , "-");
        DT = DT.Replace (":", "-");
        Directory.CreateDirectory("ScreenCapture/");
        ScreenCapture.CaptureScreenshot ("ScreenCapture/capture"+ DT + ".png");

  }

    void Update (){
        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeScreenShot();
        }         }
}

