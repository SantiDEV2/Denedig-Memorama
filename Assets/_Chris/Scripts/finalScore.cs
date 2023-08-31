using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class finalScore : MonoBehaviour
{
    
    public TMP_Text timeText;
    public float time;
    public GameObject panelPuntuacion;


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
        if (Comparisons.CartasVolteadas >= 12)
        {
            Debug.Log("DETECTE ERROR");
            panelPuntuacion.SetActive(true);
            Debug.Log("Active Panel");
        }
            

    }

    public void finalTime (TimeAccountChris finalScore)
    {
        float time = finalScore.time; 
    }
}
