using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StressRend
{
    public static string TwelveOrFan(double a)
    {
        return Math.Round(a, VerbalRamble.KarstExtent).ToString();
    }
    public static string TwelveOrFan(double a, int digits)
    {
        return Math.Round(a, digits).ToString();
    }

    public static double Karst(double a)
    {
        return Math.Round(a, VerbalRamble.KarstExtent);
    }

}
