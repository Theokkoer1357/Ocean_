using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map
{
    public Texture2D t;
   
    public Texture2D MapTopGenerate()
    {
        Texture2D T = new Texture2D(World.TheWorld.size, World.TheWorld.size);
        List<float> BedHights = new List<float>();
        for (int i = 0; i < World.TheWorld.size; i++)
        {
            float f = Mathf.Sin(Random.Range(0,1.5f) * Time.deltaTime) * 100;
            T.SetPixel(i, Mathf.RoundToInt(f), new Color(0.7f, 0.7f, 0.7f));
            for (int j = 0; j < (World.TheWorld.size - 4) - Mathf.RoundToInt(f); j++)
            {
                T.SetPixel(i, j, new Color(0.5f,0.5f,0.5f));
            }
           
            BedHights.Add(f);
        }
        T.Apply();
        t = T;
        t.Apply();
        t.filterMode = FilterMode.Point;
        return T;
      
    }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    Texture2D Chasms(Texture2D T)
    {
        int T_ = Random.Range(0, T.width);
        int T__ = T_ + 1;
        for (int i = 0; i < World.TheWorld.size; i++)
        {
            T.SetPixel(T_, i, new Color(0.7f, 0.7f, 0.7f));
        }
        return T;
    }
=======
>>>>>>> parent of 19df8f0... Chasms
=======
>>>>>>> parent of 19df8f0... Chasms
=======
>>>>>>> parent of 19df8f0... Chasms
=======
>>>>>>> parent of 19df8f0... Chasms
}
