using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int filas = 8;
    public int columnas = 3;
    public Vector2 espacio = Vector2.zero;

    public GameObject Carta;
    public Transform SpawnArea;

    void Start()
    {
        for (int x = 0; x < filas; x++)
        {
            for (int y = 0; y < columnas; y++)
            {
                GameObject cartas = Instantiate(Carta);
                cartas.transform.position = new Vector2(x * espacio.x - 4.91f, y * espacio.y - 1.55f);
            }
        }
    }
}