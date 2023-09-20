using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;

public class Spawner : MonoBehaviour
{
    public Sprite[] imagenesdeCartas;
    public Sprite[] textodeCartas;
    public int filas = 8;
    public int columnas = 3;
    public Vector2 espacio = Vector2.zero;
    public GameObject carta;
    public float Xpos = 4.91f;
    public float Ypos = 1.55f;
    private int _cartasSpawneadas = 0;

    void Start()
    {
        int totalCards = filas * columnas;

        List<int> CardIDs = MixCards(totalCards);

        for (int x = 0; x < filas; x++)
        {
            for (int y = 0; y < columnas; y++)
            {
                GameObject cartas = Instantiate(carta);

                Cards cartaenturno = cartas.GetComponent<Cards>();
                cartaenturno.id = CardIDs[_cartasSpawneadas];
                cartaenturno.AsignarImagendeCarta(imagenesdeCartas[cartaenturno.id]);
                cartaenturno.AsignarTextodeCarta(textodeCartas[cartaenturno.id]);

                cartas.transform.position = new Vector2(x * espacio.x - Xpos, y * espacio.y - Ypos);
                _cartasSpawneadas++;
            }
        }
    }

    List<int> MixCards(int totalCards)
    {
        List<int> CardIDs = new List<int>();

        for (int i = 0; i < totalCards; i++)
        {
            CardIDs.Add(i / 2);
        }

        CardIDs.Shuffle();
        return CardIDs;
    }
}