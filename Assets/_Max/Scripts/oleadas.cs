using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oleadas : MonoBehaviour
{ 
    public List<GameObject> OlaCartas; // Lista de cartas disponibles para cada oleada
    public int CantidadCartasOla = 5; // Cantidad de cartas por oleada
    public float tiempoDeOla = 10f; // Tiempo entre oleadas
    public Transform puntoAparicion; // Punto de aparición de las cartas
    private int olaActual = 0; // Oleada actual
    private float timeSinceLastWave = 0f;
    
    void Start()
    {
        StartNextWave();
    }

    void Update()
    {
        timeSinceLastWave += Time.deltaTime;

        if (timeSinceLastWave >= tiempoDeOla && olaActual < OlaCartas.Count)
        {
            StartNextWave();
        }
    }
    void StartNextWave()
    {
        if (olaActual < OlaCartas.Count)
        {
            Debug.Log("Comienza la oleada " + (olaActual + 1));

            for (int i = 0; i < CantidadCartasOla; i++)
            {
                SpawnCard(OlaCartas[olaActual]);
            }

            olaActual++;
            timeSinceLastWave = 0f;
        }
        else
        {
            Debug.Log("");
        }
    }

    void SpawnCard(GameObject cardPrefab)
    {
        Instantiate(cardPrefab, puntoAparicion.position, Quaternion.identity);
    }
}
