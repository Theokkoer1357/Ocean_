using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public static void OnGetBiome(WorldMapGenerator WMG, Texture2D T, int i, int j)
    {
        int D = Probablilty.ProbabliltyTable(WMG.Layers[i].BiomeFrequencies);
        for (int l = 0; l < WMG.Layers[i].BiomeFrequencies.Count; l++)
        {
            Debug.Log(WMG.Layers[i].BiomeFrequencies);
            if (WMG.Layers[i].BiomeFrequencies[i] == D)
            {
                WMG.WCGColor.Add(WMG.Layers[i].Biomes[i].MapToBiomeColor);
                T.SetPixel(j, i, new Color(WMG.Layers[i].Biomes[i].MapToBiomeColor, WMG.Layers[i].Biomes[i].MapToBiomeColor, WMG.Layers[i].Biomes[i].MapToBiomeColor));

                Debug.Log("EEE");
                T.Apply();
            }
            else
            {
                continue;
            }
        }
    }
}
