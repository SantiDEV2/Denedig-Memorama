using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageSwitcher : MonoBehaviour
{
    public Image imageToSwitch; // La imagen que deseas apagar y encender.
    public Sprite onSprite;     // Sprite que se mostrar� cuando se encienda la imagen.
    public Sprite offSprite;    // Sprite que se mostrar� cuando se apague la imagen.
    public TextMeshProUGUI buttonText; // Texto del bot�n TMP.
    public GameObject panelToSwitch; // El panel que deseas apagar y encender.

    private bool isImageOn = true;
    private bool isPanelOn = true;

    private void Start()
    {
        // Inicialmente, la imagen y el panel est�n encendidos.
        UpdateImage();
        UpdateButtonText();
        UpdatePanel();
    }

    public void ToggleImage()
    {
        isImageOn = !isImageOn;
        UpdateImage();
        UpdateButtonText();
    }

    public void TogglePanel()
    {
        isPanelOn = !isPanelOn;
        UpdatePanel();
    }

    private void UpdateImage()
    {
        imageToSwitch.sprite = isImageOn ? onSprite : offSprite;
    }

    private void UpdateButtonText()
    {
        buttonText.text = isImageOn ? "Apagar Imagen" : "Encender Imagen";
    }

    private void UpdatePanel()
    {
        panelToSwitch.SetActive(isPanelOn);
    }
}
