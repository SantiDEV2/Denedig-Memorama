using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour
{
    public static TextManager Instance = null;
    public TextAsset idiomaData;
    private string[] data;
    private void Awake()
    {
        PlayerPrefs.SetInt("Idioma",1);
        
        /*El numero que se pone en ese player Prefs depende de que idioma es el que quieras elegir en este caso el 0 pertenece a español, 1 a Ingles, 2 a Nahuatl y 3 Maya  */
    }

    private string result;
    public string setText(int id)
    {
        data = idiomaData.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);
        for (int i = 0; i < data.Length; i++)
        {
            
            if (id.ToString() == data[i])
            {   
                result = data[i + PlayerPrefs.GetInt("Idioma")+1];
            }
           
        }
        
        return result;
    }

    public void SetLanguage(int num)
    {
        /*Este es el metodo que le asigno a los botones para que puedan cambiar el idioma*/
        PlayerPrefs.SetInt("Idioma",num);
    }

}
