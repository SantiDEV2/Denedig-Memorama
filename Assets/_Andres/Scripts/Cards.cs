using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{
    public int ID { get; set; }
    public SpriteRenderer CartaImagen;

    private void OnMouseDown()
    {
        
    }

    public void AsignarImagendeCarta(Sprite imagen)
    {
        CartaImagen.sprite = imagen;
    }
}
