using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeAccountChris : MonoBehaviour
{
    public  static TMP_Text timetext;
    public float time;
    public GameObject canvasPuntuacion;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        DisplayTime(time);
       /* if (canvasPuntuacion(false))
        {
            canvasPuntuacion.SetActive(true);
        }*/
    }

     public void DisplayTime(float TimetoDisplay)
    {
        if (TimetoDisplay < 0)
        {
            TimetoDisplay = 0;
        }
        else if (TimetoDisplay > 0)
        {
            TimetoDisplay += 1;
        }
       
        float minutes = Mathf.FloorToInt(TimetoDisplay / 60);
        float seconds = Mathf.FloorToInt(TimetoDisplay % 60);
        /*if (seconds == 2)
        {
            Debug.Log("GameOver");
        }*/

        timetext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


}
