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
        Texture2D T = new Texture2D(5, Layers.Count);
        for (int i = 0; i < Layers.Count; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                float D = Random.Range(0,100);
                foreach (var item in Layers[i].BiomeFrequencies)
                {
                    if(D <= item)
                    {
                        WCGColor.Add(item);
                        break;
                    }
                    else
                    {
                        D -= item;
                    }
                }
               
            }
        }
        T_ = T;
        T.Apply();
        UE?.Invoke();
    }
    public void CallToGenrateChunks(WorldChunkGenerator WCG)
    {
        WCG.Generate(WCGColor);
    }
}
