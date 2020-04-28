using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Layer")]
public class Layer : ScriptableObject
{
    public int LayerInt;
    public List<BiomeProfile> Biomes;
    public List<int> BiomeFrequencies;
}
