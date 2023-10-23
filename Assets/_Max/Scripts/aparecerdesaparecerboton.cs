using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream
using UnityEngine.UI;
=======
>>>>>>> Stashed changes

public class aparecerdesaparecerboton : Comparisons
{
    public GameObject boton;
<<<<<<< Updated upstream
=======
<<<<<<< HEAD:Assets/_Max/Scripts/aparecerydesaparecerboton.cs
    public float tiempoEspera = 0.5f;

   
    private bool botonActivo = false;
=======
>>>>>>> Stashed changes
    //public Transform cartas;

    // Start is called before the first frame update

<<<<<<< Updated upstream
=======
>>>>>>> fba8f5073f83968a0839ae4e307d4b3624db2966:Assets/_Max/Scripts/aparecerdesaparecerboton.cs
>>>>>>> Stashed changes

    void Start()
    {
        boton.SetActive(false);
<<<<<<< Updated upstream
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

    
=======
    }

<<<<<<< HEAD:Assets/_Max/Scripts/aparecerydesaparecerboton.cs
    private void Update()
=======
    // Update is called once per frame

    /*bool CartasNoEnPosicionInicial()
>>>>>>> fba8f5073f83968a0839ae4e307d4b3624db2966:Assets/_Max/Scripts/aparecerdesaparecerboton.cs
    {
        logicaOleadas();
    }

    private void logicaOleadas()
    {
        if (Cuentalugar == 5 )
        {
            boton.SetActive(true);
            botonActivo = true;
            Debug.Log("Estoy prendiendo el botón");
            if (boton == true)
            {
                boton.SetActive(false);
            }
        }

        if (Cuentalugar == 9)
        {
            Debug.Log("Estoy prendiendo el botón 2");
        }
<<<<<<< HEAD:Assets/_Max/Scripts/aparecerydesaparecerboton.cs
    }

    public void DesactivarBoton()
    {
        boton.SetActive(false);
        botonActivo = false;
        Debug.Log("Estoy apagando el botón");
    }
=======
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
>>>>>>> fba8f5073f83968a0839ae4e307d4b3624db2966:Assets/_Max/Scripts/aparecerdesaparecerboton.cs


    }
>>>>>>> Stashed changes
}
