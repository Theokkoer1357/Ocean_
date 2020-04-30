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
        Texture2D T = new Texture2D(30, 30);
        Map M = new Map();
        T = M.MapTopGenerate();
        for (int i = 0; i < 30; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                WCGColor.Add(T.GetPixel(i, j).grayscale);
               
            }
        }
       
        UE?.Invoke();
    }
    public void CallToGenrateChunks(WorldChunkGenerator WCG)
    {
        WCG.Generate(WCGColor);
    }
}
