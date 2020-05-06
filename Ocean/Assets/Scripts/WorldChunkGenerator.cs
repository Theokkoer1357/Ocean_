using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldChunkGenerator : MonoBehaviour
{
    public int XChunkLength;
    public int YChunkLength;
    public GameObject Chunk;
    public List<GameObject> ChunkList = new List<GameObject>();
    
    public void Generate(List<float> FList)
    {
        int O = 0;
        for (int i = 0; i < World.TheWorld.size; i++)
        {
            for (int j = 0; j < World.TheWorld.size; j++)
            {
                float I = FList[O];
                GameObject G = Instantiate(Chunk, new Vector3(i * Chunk.transform.localScale.x, j * Chunk.transform.localScale.x, 0), Quaternion.identity);
                G.GetComponent<SpriteRenderer>().color = new Color( FList[O], FList[O], FList[O]);
                G.GetComponent<Chunk>().GenerateBlocks(gameObject.GetComponent<ChunkBiomeCheck>());
                O++;
            }
        }
    }
}
