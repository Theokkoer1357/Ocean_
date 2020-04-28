using System.Collections.Generic;
using UnityEngine;

public static class Probablilty 
{
    public static float ProbabliltyTable(List<int> Frequencies, List<float> ActualResults, float Random)
    {
        int O = 0;
        foreach (var item in Frequencies)
        {
            if (Random <= item)
            {
                float f = ActualResults[O];
                return f;
            }
            else
            {
                Random -= item;
                O++;
            }
        }
        return 1;
        
    }

}
