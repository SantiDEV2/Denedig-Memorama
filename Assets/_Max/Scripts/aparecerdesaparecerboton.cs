using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aparecerdesaparecerboton : Comparisons
{
    public GameObject boton;
    //public Transform cartas;

    // Start is called before the first frame update


    void Start()
    {
        boton.SetActive(false);
        //boton.onClick.AddListener(OcultarBoton);
    }

    // Update is called once per frame

    /*bool CartasNoEnPosicionInicial()
    {
        foreach (Transform carta in cartavol1)
        {
            if (carta.position.y != -4)
            {
                return true; 
            }
        }
        return false; 
    }*/
    void Update()
    {
       
        string texto = CheckText.text;

        
        if (texto.Contains("4 / 20")) 
        {
            boton.gameObject.SetActive(true);
        }
        else
        {
            boton.gameObject.SetActive(false);
        }
        
        /*if (texto.Contains("6 / 20"))
        {
            boton.gameObject.SetActive(true);
        }
        else
        {
            boton.gameObject.SetActive(false);
        }*/

    }

    
}
