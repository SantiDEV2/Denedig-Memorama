using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeCount : MonoBehaviour
{
    public static bool _isPaused;
    public TMP_Text timetext;
    public TMP_Text FinalTimeText;
    public TMP_Text Errors;
    public TMP_Text textScore;

    public float time;
    public GameObject canvasScoreBoard;

    public  float puntos = 9999f;

    public AudioSource sontiempo;

    public static void GamePaused()//Sonido pausa 
    {
        _isPaused = !_isPaused;
    }

    public static void GameUnPaused()
    {
        _isPaused = false;
    }

    public void pausasonidotiempo()
    {
        sontiempo.Stop();
    }

    public void playsonidotiempo()
    {
        sontiempo.Play();
    }

    void Start()
    {
        sontiempo.Play();
        _isPaused = false;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(_isPaused) return;
        if(Comparisons.Cuentalugar == 0)
        {
            Debug.Log("3");
        }

        if(Comparisons.aciertos < 28 && Comparisons.timepause == false && Comparisons.setcanvas == false)
        {
            time += Time.deltaTime;
            DisplayTime(time);
            puntos = puntos - 1 * Time.deltaTime;

            if(puntos <= 0)
            {
                puntos = 0;
            }

            Debug.Log("1");
        }
        
        if(Comparisons.aciertos >= 28)
        {
            time += 0;
            DisplayTime(time);
            print(time);
            sontiempo.Stop();
            FinalTimeText.text = time.ToString("0") + " segundos";
            Errors.text = Comparisons.errores.ToString(); 
            textScore.text = "" + puntos.ToString("0"); // Actualizar el texto de la puntuación
            canvasScoreBoard.SetActive(true);
                        Debug.Log("2");
        }

        if (Comparisons.timepause == true || Comparisons.setcanvas == true || Comparisons.setcanvascore == true)
        {
            time += 0;
            DisplayTime(time);
            sontiempo.Stop();
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
