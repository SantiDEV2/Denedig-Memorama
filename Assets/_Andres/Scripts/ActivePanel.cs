using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePanel : MonoBehaviour

{
    public GameObject panelAcierto; // Aquí va el panel acierto 
    public GameObject panelError;   // Aquí va el panel de error

    private bool panelAciertoActivo = false;
    private bool panelErrorActivo = false;

    private void Update()
    {
        if (Comparisons.aciertos == 1 && !panelAciertoActivo)
        {
            ActivarPanel(panelAcierto);
        }

        if (Comparisons.errores == 1 && !panelErrorActivo)
        {
            ActivarPanel(panelError);
        }
    }

    private void ActivarPanel(GameObject panel)
    {
        panel.SetActive(true);
        Invoke("DesactivarPanel", 1.0f);
    }

    private void DesactivarPanel()
    {
        panelAcierto.SetActive(false);
        panelError.SetActive(false);

        panelAciertoActivo = false;
        panelErrorActivo = false;
    }
}


