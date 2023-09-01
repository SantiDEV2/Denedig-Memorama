using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeCount : MonoBehaviour
{
    public TMP_Text timetext;
    private float time;

    // Update is called once per frame
    void Update()
    {
        if(Comparisons.Cuentalugar < 13)
        {
            time += Time.deltaTime;
            DisplayTime(time);
        }
        
        if(Comparisons.Cuentalugar >= 13)
        {
            time += 0;
            DisplayTime(time);
            print(time);
        }
    }

    void DisplayTime(float TimetoDisplay)
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

        timetext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
