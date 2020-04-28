using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceGeneration : MonoBehaviour, ILayerGeneration
{
    public Texture2D Generate(int width, List<float> FARR)
    {
        Texture2D T = new Texture2D(width, 1);

        return T;
    }
}
