using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChunkBiomeCheck : MonoBehaviour
{
    public List<BiomeProfile> Biomes;
    public List<float> BiomeGrayScale;
    public BiomeProfile GetBiome(float GrayScale)
    {
        for (int i = 0; i < BiomeGrayScale.Count; i++)
        {
            if(GrayScale == BiomeGrayScale[i])
            {
                return Biomes[i];
            }
            else
            {
                continue;
            }
        }
        return Biomes[0];
    }
}
