using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SurfaceGeneration : MonoBehaviour ,IBiomeGeneration
{
    public Block[] BlockToGenerate(List<Block> Pallete, List<float> BlockMapData, Texture2D Map)
    {
        Block[] B = new Block[25];
        int O = 0;
        int H = 0;
        for (int i = 0; i < Map.width; i++)
        {
            for (int j = 0; j < Map.height; j++)
            {
                foreach (var item in BlockMapData)
                {

                    if (item == Map.GetPixel(i, j).grayscale)
                    {
                        B[i] = Pallete[H];
                    }
                    else
                    {

                    }
                    H++;
                }
                H = 0;
                O++;
            }

        }
        return B;
    }

    public Texture2D GenerateMap(int width, int length, BiomeProfile Biome)
    {
        Texture2D T = new Texture2D(width, length);
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < length; j++)
            {
                T.SetPixel(i, j, new Color(1, 1, 1));
            }
        }
        T.Apply();
        return T;
    }

    public bool PreBiomeLocationCheck()
    {
        throw new System.NotImplementedException();
    }
}
