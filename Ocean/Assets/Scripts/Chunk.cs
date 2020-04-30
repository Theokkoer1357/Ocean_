using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Chunk : MonoBehaviour
{
    public void GenerateBlocks(ChunkBiomeCheck CBC)
    {
        // Gets Biome
        float f = (float)Math.Round(GetComponent<SpriteRenderer>().color.grayscale, 1);
        BiomeProfile B = CBC.GetBiome(f);

        // Does BiomeGeneration
        if (B.BiomeGeneration is IBiomeGeneration)
        {
            Debug.Log("yes");
        }
    }
}
