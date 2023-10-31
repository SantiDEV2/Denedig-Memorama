using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Comparisons : MonoBehaviour
{
    public TextMeshProUGUI CheckText;
    public TextMeshProUGUI WrongText;

    public static int aciertos = 0;
    public static int errores = 0;
    public static int CartasVolteadas = 0;
    public static int firstID;
    public static int secondID;

    public static bool Errortimerend = false;
    public static bool Checktimerend = false;

    public static GameObject cartavol1;
    public static GameObject cartavol2;

    public static int Cuentalugar = 20;

    public float makebigtime;

    public Vector3 size = new Vector3(0, 0, 0);
    public Vector3 centresize = new Vector3(0, 0, 0);

    public Transform tocenterleft;
    public Transform tocenterright;

    public GameObject ruleta;
    public Animator rule;

    //Transforms
    #region
    public Transform pila1;
    public Transform pila2;
    public Transform pila3;
    public Transform pila4;
    public Transform pila5;
    public Transform pila6;
    public Transform pila7;
    public Transform pila8;
    public Transform pila9;
    public Transform pila10;
    public Transform pila11;
    public Transform pila12;
    #endregion

    void Start()
    {
        rule.enabled = false;
        ruleta.SetActive(false);
        Cuentalugar = 1;
        aciertos = 0;
        errores = 0;
    }

    void Update()
    {
        if (CartasVolteadas == 2)
        {
            print(firstID);
            print(secondID);

            Cursor.lockState = CursorLockMode.Locked;
            if (firstID == secondID)
            {
                aciertos = aciertos + 1;
                CheckText.text = aciertos.ToString() + " / 20";
                CartasVolteadas = 0;
                Checktimerend = true;

                if(Checktimerend == true)
                {
                    /*settings1.PlaySfx("EXITO");*/

                    StartCoroutine(Makebig());                  
                }
            }

            if(firstID != secondID)
            {
                errores = errores + 1;
                WrongText.text = errores.ToString();
                CartasVolteadas = 0;
                Errortimerend = true;

                if(Errortimerend == true)
                {
                    /*settings1.PlaySfx("ERROR");*/
                    StartCoroutine(Corspaw());
                }
            }
        }
    }

    private IEnumerator Corspaw()
    {
        yield return new WaitForSeconds(.5f);

        //cartavol1.transform.Rotate(0, 180, 0);
        //cartavol2.transform.Rotate(0, 180, 0);

        cartavol1.GetComponent<Animator>().SetTrigger("Close");
        cartavol2.GetComponent<Animator>().SetTrigger("Close");

        cartavol1.GetComponent<BoxCollider>().enabled = true;
        cartavol2.GetComponent<BoxCollider>().enabled = true;

        Errortimerend = false;
        Cursor.lockState = CursorLockMode.None;
        StopAllCoroutines();
    }

    private IEnumerator Truespaw()
    {
        yield return new WaitForSeconds(.5f);

        rule.enabled = false;
        ruleta.SetActive(false);

        CorrectParPos();

        Checktimerend = false;
        Cursor.lockState = CursorLockMode.None;
        Cuentalugar = Cuentalugar + 1;
        StopAllCoroutines();
    }

    private IEnumerator Makebig()
    {
        cartavol1.GetComponent<Animator>().enabled = false;
        cartavol2.GetComponent<Animator>().enabled = false;

        cartavol1.transform.position = tocenterleft.transform.position;
        cartavol2.transform.position = tocenterright.transform.position;

        cartavol1.transform.localScale = centresize;
        cartavol2.transform.localScale = centresize;

        cartavol1.transform.rotation = tocenterleft.transform.rotation;
        cartavol2.transform.rotation = tocenterright.transform.rotation;

        ruleta.SetActive(true);
        rule.enabled = true;

        yield return new WaitForSeconds(makebigtime);

        StopCoroutine(Makebig());
        StartCoroutine(Truespaw());
    }

    void CorrectParPos()//sonidos en los if cuando aciertos 
    {
        if (Cuentalugar == 1)
        {
            cartavol1.transform.position = pila1.transform.position;
            cartavol1.transform.localScale = size;
            
            cartavol2.transform.position = pila1.transform.position + new Vector3(.12f,0,.1f);
            cartavol2.transform.localScale = size;
        }

        if (Cuentalugar == 2)
        {
            cartavol1.transform.position = pila2.transform.position;
            cartavol1.transform.localScale = size;

            cartavol2.transform.position = pila2.transform.position + new Vector3(.12f, 0, .1f);
            cartavol2.transform.localScale = size;
        }

        if (Cuentalugar == 3)
        {
            cartavol1.transform.position = pila3.transform.position;
            cartavol1.transform.localScale = size;

            cartavol2.transform.position = pila3.transform.position + new Vector3(.12f, 0, .1f);
            cartavol2.transform.localScale = size;
        }

        if (Cuentalugar == 4)
        {
            cartavol1.transform.position = pila4.transform.position;
            cartavol1.transform.localScale = size;

            cartavol2.transform.position = pila4.transform.position + new Vector3(.12f, 0, .1f);
            cartavol2.transform.localScale = size;
        }

        if (Cuentalugar == 5)
        {
            cartavol1.transform.position = pila5.transform.position;
            cartavol1.transform.localScale = size;

            cartavol2.transform.position = pila5.transform.position + new Vector3(.12f, 0, .1f);
            cartavol2.transform.localScale = size;
        }

        if (Cuentalugar == 6)
        {
            cartavol1.transform.position = pila6.transform.position;
            cartavol1.transform.localScale = size;

            cartavol2.transform.position = pila6.transform.position + new Vector3(.12f, 0, .1f);
            cartavol2.transform.localScale = size;
        }

        if (Cuentalugar == 7)
        {
            cartavol1.transform.position = pila7.transform.position;
            cartavol1.transform.localScale = size;

            cartavol2.transform.position = pila7.transform.position + new Vector3(.12f, 0, .1f);
            cartavol2.transform.localScale = size;
        }

        if (Cuentalugar == 8)
        {
            cartavol1.transform.position = pila8.transform.position;
            cartavol1.transform.localScale = size;

            cartavol2.transform.position = pila8.transform.position + new Vector3(.12f, 0, .1f);
            cartavol2.transform.localScale = size;
        }

        if (Cuentalugar == 9)
        {
            cartavol1.transform.position = pila9.transform.position;
            cartavol1.transform.localScale = size;

            cartavol2.transform.position = pila9.transform.position + new Vector3(.12f, 0, .1f);
            cartavol2.transform.localScale = size;
        }

        if (Cuentalugar == 10)
        {
            cartavol1.transform.position = pila10.transform.position;
            cartavol1.transform.localScale = size;

            cartavol2.transform.position = pila10.transform.position + new Vector3(.12f, 0, .1f);
            cartavol2.transform.localScale = size;
        }

        if (Cuentalugar == 11)
        {
            cartavol1.transform.position = pila11.transform.position;
            cartavol1.transform.localScale = size;

            cartavol2.transform.position = pila11.transform.position + new Vector3(.12f, 0, .1f);
            cartavol2.transform.localScale = size;
        }

        if (Cuentalugar == 12)
        {
            cartavol1.transform.position = pila12.transform.position;
            cartavol1.transform.localScale = size;

            cartavol2.transform.position = pila12.transform.position + new Vector3(.12f, 0, .1f);
            cartavol2.transform.localScale = size;
        }
    }
}
