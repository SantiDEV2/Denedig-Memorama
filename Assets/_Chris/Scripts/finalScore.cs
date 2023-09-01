using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class finalScore : MonoBehaviour
{
    public TMP_Text tiempo;
    public float score;

    void Start()
    {
        // Obtener el tiempo guardado en PlayerPrefs
        Debug.Log("Obtuve el tiempo del pasado");
        float tiempoGuardado = PlayerPrefs.GetFloat("TiempoGuardado", 0f);
        Debug.Log("Tiempo");
        // Mostrar el tiempo en el Text
        tiempo.text = "Tiempo: " + tiempoGuardado.ToString("F2");
    
    }

 

    
}
 

    



