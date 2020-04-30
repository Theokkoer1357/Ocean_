using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBiomeGeneration 
{
    bool PreBiomeLocationCheck();
    Texture2D GenerateMap(int width, int length, BiomeProfile Biome);

    Block[] BlockToGenerate(List<Block> Pallete, List<float> BlockMapData, Texture2D Map);
    
}
