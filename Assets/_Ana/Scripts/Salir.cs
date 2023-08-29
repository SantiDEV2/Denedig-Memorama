using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Detecta si se presiona la tecla Escape
        {
            Salida(); // Llama a la funci�n Salir
        }
    }

    public void Salida()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Detiene la reproducci�n en el Editor de Unity
#else
            Application.Quit(); // Sale de la aplicaci�n en un build standalone
#endif
    }
}
