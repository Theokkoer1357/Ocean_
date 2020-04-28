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
        Texture2D T = new Texture2D(5, Layers.Count);
        for (int i = 0; i < Layers.Count; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                float D = Random.Range(0,100);
                int O = 0;
                foreach (var item in Layers[i].BiomeFrequencies)
                {
                    if(D <= item)
                    {
                        float f = Layers[i].Biomes[O].MapToBiomeColor;
                        T.SetPixel(i, j,new Color(f / 255, f / 255, f / 255));
                        WCGColor.Add(f);
                        break;
                    }
                    else
                    {
                        D -= item;
                        O++;
                    }
                }
               
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
