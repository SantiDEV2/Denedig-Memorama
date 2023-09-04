using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class finalScore : MonoBehaviour
{
    public TMP_Text tiempo;
    public TMP_Text textScore;
    public float score1;
    public float score2;

    void Start()
    {
        // Obtener el tiempo guardado en PlayerPrefs
        //Debug.Log("Obtuve el tiempo del pasado");
        float tiempoGuardado = PlayerPrefs.GetFloat("TiempoGuardado", 0f);
       // Debug.Log("Tiempo");
        // Mostrar el tiempo en el Text
        tiempo.text = "Tiempo: " + tiempoGuardado.ToString("F2");
        puntuacion();

    }
    private void Update()
    {
      
    }

  void puntuacion()
  {
    Debug.Log("Empece puntuacion");
    float tiempoGuardado1 = PlayerPrefs.GetFloat("Tiempo Guardado2", 0);
    Debug.Log("Obtuve tiempo");

    int puntos = 1000; // Establecer la cantidad predeterminada en 1000 puntos

    if (tiempoGuardado1 <= 50)
    {
        Debug.Log("Empece condicion");
        puntos += 10 * (50 - (int)tiempoGuardado1); // Añadir 10 puntos por cada unidad por debajo de 50
    }
    else
    {
        puntos -= 5 * ((int)tiempoGuardado1 - 50); // Restar 5 puntos por cada unidad por encima de 50
    }

    if (puntos < 0)
    {
        puntos = 0; // Asegurarse de que el puntaje no sea negativo
    }

    textScore.text = $"Felicidades juntaste {puntos} puntos"; // Actualizar el texto de la puntuación
  }
}



