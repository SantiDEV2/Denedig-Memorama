using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextSizeAndFontChanger : MonoBehaviour
{
    public List<TextMeshProUGUI> textMeshProTexts; // Arrastra los objetos de texto TextMeshPro aquí en el Inspector
    public float newSize = 20f; // Tamaño del texto que deseas establecer al hacer clic en el botón
    public TMP_FontAsset newFont; // Fuente que deseas establecer al hacer clic en el botón

    private void Start()
    {
        // Asegúrate de que al menos un objeto TextMeshPro esté asignado en el Inspector
        if (textMeshProTexts == null || textMeshProTexts.Count == 0)
        {
            Debug.LogError("No se han asignado objetos TextMeshPro en la lista en el Inspector.");
        }
    }

    public void ChangeTextSizeAndFont()
    {
        // Itera a través de la lista de objetos TextMeshPro y cambia su tamaño y fuente
        foreach (var textMeshProText in textMeshProTexts)
        {
            // Cambia el tamaño del texto TextMeshPro al valor especificado
            textMeshProText.fontSize = newSize;

            // Cambia la fuente del texto TextMeshPro al valor especificado
            textMeshProText.font = newFont;
        }
    }
}
