using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    public Slider slider;       // Referencia al objeto Slider
    public AudioSource audioSource; // Referencia al objeto AudioSource

    void Start()
    {
        // Configurar el valor inicial del slider al volumen actual
        slider.value = audioSource.volume;

        // Agregar un listener para detectar cambios en el slider
        slider.onValueChanged.AddListener(CambiarVolumen);
    }

    void CambiarVolumen(float nuevoVolumen)
    {
        audioSource.volume = nuevoVolumen; // Cambiar el volumen del AudioSource
    }
}
