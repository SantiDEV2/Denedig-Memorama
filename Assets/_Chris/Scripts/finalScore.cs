using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class finalScore : MonoBehaviour
{
    
    public  TMP_Text timeText1;
    public float time1;
    public GameObject panelPuntuacion;
    public float score;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        Puntuacion();
    }
    // Update is called once per frame
    private void Puntuacion ()
    {
        if (Comparisons.CartasVolteadas >= 2)
        {
            Debug.Log("DETECTE ERROR");
            panelPuntuacion.SetActive(true);
            Debug.Log("Active Panel");
        }
            

    }

    public void finalTime ()
    {
        if (panelPuntuacion == true)
        {
           TimeAccountChris timeChris = FindObjectOfType<TimeAccountChris>();
           //timeText1 = TimeAccountChris

        }
    }
}
