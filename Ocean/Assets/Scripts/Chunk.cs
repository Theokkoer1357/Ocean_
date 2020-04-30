using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Chunk : MonoBehaviour
{
    public void GenerateBlocks(ChunkBiomeCheck CBC)
    {
        float f = (float)Math.Round(GetComponent<SpriteRenderer>().color.grayscale, 1);
    }
}
