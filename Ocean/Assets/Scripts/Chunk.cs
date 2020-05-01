using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
public class Chunk : MonoBehaviour
{
    public Texture2D T;
    public Block[] BARR = new Block[25];
    public List<Vector2> BlockPos;
    public void GenerateBlocks(ChunkBiomeCheck CBC)
    {
        // Gets Biome
        float f = (float)Math.Round(GetComponent<SpriteRenderer>().color.grayscale, 1);
        BiomeProfile B = CBC.GetBiome(f);

        // Do Biome Logic Generation
        var Biome = B.BiomeGeneration.GetComponent<IBiomeGeneration>();
        if(Biome != null)
        {
            T = Biome.GenerateMap(5, 5, B);
            BARR = Biome.BlockToGenerate(B.Pallete, B.BlockHights, T);
        }
        else
        {
            Debug.LogError("Generation Type not of .IBiomeGeneration -- The class does not Impliment the Interface and a problem occurred");
        }

        // Instantiate Blocks
        for (int i = 0; i < BARR.Length; i++)
        {
            
            if (BARR[i] != null)
            {
                GameObject G = Instantiate(BARR[i].PreCoExistingEffects);
                G.transform.parent = transform;
                G.transform.localPosition = BlockPos[i];
                G.AddComponent<SpriteRenderer>();
                G.GetComponent<SpriteRenderer>().sprite = BARR[i].BlockSprite;
            }
        }

        // Hide Chunk

    }
}
