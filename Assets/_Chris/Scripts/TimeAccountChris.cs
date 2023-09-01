using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeAccountChris : MonoBehaviour
{
   
    public TMP_Text timetext;
    public float time;
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
    }
    private void FinalizarJuego()
    {
        Debug.Log("Se guardo tiempo en prefs ");
        PlayerPrefs.SetFloat("TiempoGuardado", time); // Guarda el tiempo en PlayerPrefs
        Debug.Log("vamos bien ");
        PlayerPrefs.Save();
        Debug.Log("Se guardo bien  ");
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
            FinalizarJuego(); // Llama a FinalizarJuego cuando se cumpla la condición
        }
    }

   
}