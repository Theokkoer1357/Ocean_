using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WorldMapGenerator : MonoBehaviour
{
    public List<Layer> Layers;
    public UnityEvent UE = new UnityEvent();
    public List<float> WCGColor;
    public Texture2D T_;
    private void Start()
    {
        GenerateMap();
    }
    void GenerateMap()
    {
        Texture2D T = new Texture2D(50, Layers.Count);
        for (int i = 0; i < Layers.Count; i++)
        {
            for (int j = 0; j < 50; j++)
            {
                float D = Random.Range(0,100);
                List<float> A = new List<float>();
                for (int l = 0; l < Layers[i].Biomes.Count; l++)
                {
                    A.Add(Layers[i].Biomes[l].MapToBiomeColor);
                }
                float f = Probablilty.ProbabliltyTable(Layers[i].BiomeFrequencies, A, D);
                WCGColor.Add(f);
                T.SetPixel(i, j, new Color(f, f, f));
               
            }
        }
        T.Apply();
        T_ = T;
        T_.Apply();
        UE?.Invoke();
    }
    public void CallToGenrateChunks(WorldChunkGenerator WCG)
    {
        WCG.Generate(WCGColor);
    }
}
