using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILayerGeneration 
{
    Texture2D Generate(int width, List<float> FARR);
    
}
