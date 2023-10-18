using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparecerydesaparecerboton : MonoBehaviour
{
    public GameObject boton;
    public List<Collider> collidersDeCartasEnOleada = new List<Collider>();
    // Start is called before the first frame update
    void VerificarCollidersDeOleada()
    {
        if (collidersDeCartasEnOleada.Count == 0)
        {
            boton.SetActive(true); // Activa el objeto del botón
        }
    }

    void Start()
    {
        boton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
