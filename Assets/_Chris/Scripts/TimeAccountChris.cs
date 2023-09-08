using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeAccountChris : MonoBehaviour
{

    public TMP_Text timetext;
    public float time;
    public int puntaje;
    public GameObject canvasPuntuacion;
    private bool detenerTiempo = false;

    void Update()
    {
        if (!detenerTiempo) // Solo avanza el tiempo si detenerTiempo es falso
        {
            time += Time.deltaTime;
            DisplayTime(time);
            Puntuacion();
        }
        if (time >= 0)
        {
            puntaje = 100;
        }
        if (time >= 50)
        {
            puntaje = 50;
        }
    }
    private void FinalizarJuego()
    {
       
        PlayerPrefs.SetFloat("TiempoGuardado", time); // Guarda el tiempo en PlayerPrefs
        PlayerPrefs.SetInt("PuntajeGuardado", puntaje);
       
        PlayerPrefs.Save();
        
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

        timetext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void Puntuacion()
    {
        if (Comparisons.errores >= 1)
        {
            canvasPuntuacion.SetActive(true);
            detenerTiempo = true;
            FinalizarJuego(); // Llama a FinalizarJuego cuando se cumpla la condici�n
        }
    }

   
}