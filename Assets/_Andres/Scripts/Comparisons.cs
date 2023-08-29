using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comparisons : MonoBehaviour
{
    public static int CartasVolteadas = 0;
    public static int firstID;
    public static int secondID;

    void Start()
    {
        
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
                print("yay!");
            }
        }
    }
}
