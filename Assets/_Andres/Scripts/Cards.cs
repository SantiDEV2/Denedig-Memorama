using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{
    public int ID { get; set; }
    public SpriteRenderer CartaImagen;

    public int selectcart;

    void Start()
    {
       
    }

    public void OnMouseDown()
    {
        this.transform.Rotate(0,180,0);
        Comparisons.CartasVolteadas += 1;
        selectcart = this.ID;

        if (Comparisons.CartasVolteadas == 1)
        {
            Comparisons.firstID = selectcart;
        }

        if (Comparisons.CartasVolteadas == 2)
        {
            Comparisons.secondID = selectcart;
        }

    }

    public void AsignarImagendeCarta(Sprite imagen)
    {
        CartaImagen.sprite = imagen;
    }
}
