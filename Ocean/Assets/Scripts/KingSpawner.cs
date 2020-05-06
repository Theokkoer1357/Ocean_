using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KingSpawner : MonoBehaviour
{
    public GameObject G;
    public void Start()
    {
        Instantiate(G, SpawnLoc(), Quaternion.identity);
    }
    public Vector2 SpawnLoc()
    {
        /*int x = UnityEngine.Random.Range(0, World.TheWorld.size);
        int y = UnityEngine.Random.Range(0, World.TheWorld.size);

        float z = World.TheWorld.WorldText.GetPixel(x, y).grayscale;
        if (Math.Round((double)z, 1) == 0.7f)
        {
            return new Vector2(x, y);
        }
        else
        {
            return new Vector2(0, 0);
        }*/
        return new Vector2();
    }
}
