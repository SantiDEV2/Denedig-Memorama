using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class aparecerdesaparecerboton : Comparisons
{
    public GameObject boton;

    public float tiempoEspera = 0.5f;

   
    private bool botonActivo = false;


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


    


   /* private void Update()
    {
        logicaOleadas();
    }*/

    /*private void logicaOleadas()
    {
        if (Cuentalugar == 5 )
        {
            boton.SetActive(true);
            botonActivo = true;
            Debug.Log("Estoy prendiendo el bot�n");
            if (boton == true)
            {
                boton.SetActive(false);
            }
        }

        if (Cuentalugar == 9)
        {
            Debug.Log("Estoy prendiendo el bot�n 2");
        }

    }

    public void DesactivarBoton()
    {
        boton.SetActive(false);
        botonActivo = false;
        Debug.Log("Estoy apagando el bot�n");
    

        if (Cuentalugar == 12)
        {
            boton.gameObject.SetActive(true);
        }
        if (Cuentalugar == 16)
        {
            boton.gameObject.SetActive(true);
        }
        if (Cuentalugar == 20)
        {
            boton.gameObject.SetActive(true);
        }

    }*/

}
