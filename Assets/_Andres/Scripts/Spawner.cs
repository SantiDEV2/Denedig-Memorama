using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Sprite[] ImagenesdeCartas;
    public int filas = 8;
    public int columnas = 3;
    public Vector2 espacio = Vector2.zero;

    public GameObject Carta;
    public Transform SpawnArea;

    private int CartasSpawneadas = 0; 

    void Start()
    {
        int TotalCards = filas * columnas;

        List<int> CardIDs = MixCards(TotalCards);

        for (int x = 0; x < filas; x++)
        {
            for (int y = 0; y < columnas; y++)
            {
                GameObject cartas = Instantiate(Carta);

                Cards cartaenturno = cartas.GetComponent<Cards>();
                cartaenturno.ID = CardIDs[CartasSpawneadas];
                cartaenturno.AsignarImagendeCarta(ImagenesdeCartas[cartaenturno.ID]);

                cartas.transform.position = new Vector2(x * espacio.x - 4.91f, y * espacio.y - 1.55f);
                CartasSpawneadas++;
            }
        }
    }

    List<int> MixCards(int TotalCards)
    {
        List<int> CardIDs = new List<int>();

        for (int i = 0; i < TotalCards; i++)
        {
            CardIDs.Add(i / 2);
        }

        CardIDs.Shuffle();
        return CardIDs;
    }
}