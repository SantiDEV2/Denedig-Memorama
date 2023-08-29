using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Detecta si se presiona la tecla Escape
        {
            Salida(); // Llama a la función Salir
        }
    }

    public void Salida()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Detiene la reproducción en el Editor de Unity
#else
            Application.Quit(); // Sale de la aplicación en un build standalone
#endif
    }
}
