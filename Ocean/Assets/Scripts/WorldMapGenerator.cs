using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WorldMapGenerator : MonoBehaviour
{
    public List<Layer> Layers;
    public UnityEvent UE = new UnityEvent();
    public List<float> WCGColor;
    public Texture T_;
    private void Start()
    {
        GenerateMap();
    }
    void GenerateMap()
    {
        Texture2D T = new Texture2D(6, Layers.Count);
        for (int i = 0; i < Layers.Count; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Chunk.OnGetBiome(this, T, i, j);
                
            }
        }
        T_ = T;
        UE?.Invoke();
    }
    public void CallToGenrateChunks(WorldChunkGenerator WCG)
    {
        WCG.Generate(WCGColor);
    }
}
