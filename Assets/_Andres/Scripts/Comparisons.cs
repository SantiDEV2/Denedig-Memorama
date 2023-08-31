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

    public static bool timerend = false;

    public static GameObject cartavol1;
    public static GameObject cartavol2;

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
                CheckText.text = aciertos.ToString() + " / 12";
            }

            if(firstID != secondID)
            {
                errores = errores + 1;
                WrongText.text = errores.ToString();
                CartasVolteadas = 0;
                timerend = true;

                if(timerend == true)
                {
                    StartCoroutine(Corspaw());
                }
            }
        }
    }

    private IEnumerator Corspaw()
    {
        yield return new WaitForSeconds(1);

        cartavol1.transform.Rotate(0, 180, 0);
        cartavol2.transform.Rotate(0, 180, 0);

        cartavol1.GetComponent<BoxCollider>().enabled = true;
        cartavol2.GetComponent<BoxCollider>().enabled = true;

        timerend = false;
        Cursor.lockState = CursorLockMode.None;
        StopAllCoroutines();
    }
}
