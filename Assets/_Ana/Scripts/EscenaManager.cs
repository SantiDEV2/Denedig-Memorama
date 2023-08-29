using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaManager : MonoBehaviour
{
    public string nombreEscena; // Nombre de la escena a la que deseas cambiar

    public void CambiarAEscena()
    {
        SceneManager.LoadScene(nombreEscena); // Carga la escena con el nombre especificado
    }
}
