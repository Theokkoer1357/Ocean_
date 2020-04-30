using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBiomeGeneration 
{
    bool PreBiomeLocationCheck();
    Texture2D Generate(int width, List<float> BlockLevels);
    
}
