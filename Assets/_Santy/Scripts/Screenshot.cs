using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    private int _i=0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _i++;
            ScreenCapture.CaptureScreenshot("screenshot{_i}.png");  
            Debug.Log("A screenshot was taken!"); 
        }
    }
}
