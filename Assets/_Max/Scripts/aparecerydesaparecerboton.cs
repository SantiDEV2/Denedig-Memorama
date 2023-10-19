using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparecerydesaparecerboton : Comparisons
{
    public GameObject boton;
    //public Transform cartas;
   
    // Start is called before the first frame update
   

    void Start()
    {
        boton.SetActive(false);
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
        if (Cuentalugar == 8)
        {
            boton.gameObject.SetActive(true);
        }
        
    }

}
