using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterRound
{
    public static float Round(float numberToRound, int howManyPlaces)
    {
        numberToRound *= Mathf.Pow(10, howManyPlaces);
        numberToRound = Mathf.Round(numberToRound);
        numberToRound /= Mathf.Pow(10, howManyPlaces);
        return (numberToRound);
    }
}
