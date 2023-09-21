using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class ModeChange : MonoBehaviour
{
    public ColorBlindFilter ColorBlindFilter;

    //Bools
    #region
    public static bool normalColor = false;
    public static bool protanopiaColor = false;
    public static bool protanomaliaColor = false;
    public static bool deuteranopiaColor = false;
    public static bool deuteranomaliaColor = false;
    public static bool tritanopiaColor = false;
    public static bool tritanomaliaColor = false;
    public static bool acromatopsiaColor = false;
    public static bool acronomatomaliaColor = false;
    #endregion

    void Awake()
    {        
        if (normalColor == true)
        {
            ColorBlindFilter.mode = ColorBlindMode.Normal;
        }

        if (protanopiaColor == true)
        {
            ColorBlindFilter.mode = ColorBlindMode.Protanopia;
        }

        if (protanomaliaColor == true)
        {
            ColorBlindFilter.mode = ColorBlindMode.Protanomaly;
        }

        if (deuteranopiaColor == true)
        {
            ColorBlindFilter.mode = ColorBlindMode.Deuteranopia;
        }

        if (deuteranomaliaColor == true)
        {
            ColorBlindFilter.mode = ColorBlindMode.Deuteranomaly;
        }

        if (tritanopiaColor == true)
        {
            ColorBlindFilter.mode = ColorBlindMode.Tritanopia;
        }

        if (tritanomaliaColor == true)
        {
            ColorBlindFilter.mode = ColorBlindMode.Tritanomaly;
        }

        if (acromatopsiaColor == true)
        {
            ColorBlindFilter.mode = ColorBlindMode.Achromatopsia;
        }

        if (acronomatomaliaColor == true)
        {
            ColorBlindFilter.mode = ColorBlindMode.Achromatomaly;
        }
    }

    public void ColorModeChange(int index)
    {
        if(index == 0)
        {
            ColorBlindFilter.mode = ColorBlindMode.Normal;
        }

        if(index == 1)
        {
            ColorBlindFilter.mode = ColorBlindMode.Protanopia;
        }

        if(index == 2)
        {
            ColorBlindFilter.mode = ColorBlindMode.Protanomaly;
        }

        if(index == 3)
        {
            ColorBlindFilter.mode = ColorBlindMode.Deuteranopia;
        }

        if(index == 4)
        {
            ColorBlindFilter.mode = ColorBlindMode.Deuteranomaly;
        }

        if(index == 5)
        {
            ColorBlindFilter.mode = ColorBlindMode.Tritanopia;
        }

        if(index == 6)
        {
            ColorBlindFilter.mode = ColorBlindMode.Tritanomaly;
        }

        if(index == 7)
        {
            ColorBlindFilter.mode = ColorBlindMode.Achromatopsia;
        }

        if(index == 8)
        {
            ColorBlindFilter.mode = ColorBlindMode.Achromatomaly;
        }
    }
}