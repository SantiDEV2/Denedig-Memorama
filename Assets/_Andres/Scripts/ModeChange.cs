using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeChange : MonoBehaviour
{
    public ColorBlindFilter ColorBlindFilter;

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