using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldChunkGenerator : MonoBehaviour
{
    public int XChunkLength;
    public int YChunkLength;
    public GameObject Chunk;
    public void Awake()
    {
        for (int i = 0; i < XChunkLength; i++)
        {
            for (int j = 0; j < YChunkLength; j++)
            {
                Instantiate(Chunk, new Vector3(i * Chunk.transform.localScale.x, j * Chunk.transform.localScale.x, 0), Quaternion.identity);
            }
        }
    }
}
