using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeAccountChris : MonoBehaviour
{
    public TMP_Text timetext;
    public  float time;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        DisplayTime(time);
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
