using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Cards : MonoBehaviour
{
    public int id { get; set; }
    public SpriteRenderer cartaImagen;
    public SpriteRenderer TextoImagen;

    private int _selectcart;
    private GameObject _cartaselec;
    public Animator animopen;

    public void OnMouseDown()
    {
        animopen.SetTrigger("Open");
        //this.transform.Rotate(0,180,0);
        Comparisons.CartasVolteadas += 1;
        _selectcart = this.id;
        _cartaselec = this.gameObject;
        

        if (Comparisons.CartasVolteadas == 1)
        {
            Comparisons.firstID = _selectcart;
            Comparisons.cartavol1 = _cartaselec;
            this.GetComponent<BoxCollider>().enabled = false;
        }

        if (Comparisons.CartasVolteadas == 2)
        {
            Comparisons.secondID = _selectcart;
            Comparisons.cartavol2 = _cartaselec;
            this.GetComponent<BoxCollider>().enabled = false;
        }     
    }

    public void AsignarImagendeCarta(Sprite imagen)
    {
        cartaImagen.sprite = imagen;
    }

    public void AsignarTextodeCarta(Sprite Texto)
    {
        TextoImagen.sprite = Texto;
    }
}
