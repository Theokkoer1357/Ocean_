using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Biome")]
public class BiomeProfile : ScriptableObject
{
    public List<Block> Pallete;
    public Color TEMP;
    public MonoBehaviour Biome;
    public float MapToBiomeColor;
}
