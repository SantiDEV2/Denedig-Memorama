using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{
    public int ID { get; set; }
    public SpriteRenderer CartaImagen;

    public int selectcart;
    public GameObject cartaselec;
    public Animator animopen;

    public void OnMouseDown()
    {
        animopen.SetTrigger("Open");
        //this.transform.Rotate(0,180,0);
        Comparisons.CartasVolteadas += 1;
        selectcart = this.ID;
        cartaselec = this.gameObject;

        if (Comparisons.CartasVolteadas == 1)
        {
            Comparisons.firstID = selectcart;
            Comparisons.cartavol1 = cartaselec;
            this.GetComponent<BoxCollider>().enabled = false;
        }

        if (Comparisons.CartasVolteadas == 2)
        {
            Comparisons.secondID = selectcart;
            Comparisons.cartavol2 = cartaselec;
            this.GetComponent<BoxCollider>().enabled = false;
        }     
    }

    public void AsignarImagendeCarta(Sprite imagen)
    {
        CartaImagen.sprite = imagen;
    }
}
