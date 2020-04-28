using System.Collections.Generic;
using UnityEngine;

public static class Probablilty 
{
    public static int ProbabliltyTable(List<int> A)
    {
        List<int> Likelyness = new List<int>(100);
        for (int i = 0; i < A.Count; i++)
        {
            int B = A[i];
            for (int j = 0; j < B; j++)
            {
                Likelyness.Add(B);
            }
        }
        
        int C = Random.Range(0, 100);
        Debug.Log(Likelyness);
        int D = Likelyness[C];
        Debug.Log(D);
        return D;
    }

}
