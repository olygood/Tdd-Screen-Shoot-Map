using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//public AudioClip soundScreenShot;
public class Shot : MonoBehaviour
{
    void TakeScreenShot (){

 //GetComponent<AudioSource> (). PlayOneShot (soundScreenShot);//si j'ai pas ne pas le mettre

string DT = System.DateTime.Now.ToString (); //renomer le jpg string pas int
DT = DT.Replace ("/" , "-");
DT = DT.Replace (":", "-");
        
    ScreenCapture.CaptureScreenshot ("capture"+ DT + ".png");
        

    }

    void Update (){
        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeScreenShot();
        }         }
}

