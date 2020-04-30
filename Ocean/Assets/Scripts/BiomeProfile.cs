using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "Biome")]
public class BiomeProfile : ScriptableObject
{
    public List<Block> Pallete;
    public Color TEMP;
    public MonoScript BiomeGeneration;
    public float MapToBiomeColor;
}
