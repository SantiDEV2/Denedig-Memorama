    using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeCount : MonoBehaviour
{
    public TMP_Text timetext;
    public TMP_Text FinalTimeText;
    public TMP_Text Errors;
    public TMP_Text textScore;

    public float time;
    public GameObject canvasPuntuacion;
    public GameObject canvasScoreBoard;

    public  float puntos = 9999f;

    void Start()
    {
        time = 0;
        canvasPuntuacion.SetActive(false);
        canvasScoreBoard.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Comparisons.Cuentalugar < 12)
        {
            time += Time.deltaTime;
            DisplayTime(time);
            puntos = puntos - 1 * Time.deltaTime;

            if(puntos <= 0)
            {
                puntos = 0;
            }
        }
        
        if(Comparisons.Cuentalugar >= 13)
        {
            time += 0;
            DisplayTime(time);
            print(time);
            FinalTimeText.text = time.ToString() + " segundos";
            Errors.text = Comparisons.errores.ToString(); 
            canvasPuntuacion.SetActive(true);
            textScore.text = "" + puntos.ToString(); // Actualizar el texto de la puntuación
            canvasScoreBoard.SetActive(true);
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
