using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassGeneration : MonoBehaviour, IBlockAddon
{
    public bool HasRayCasted;
    public Sprite Grass;
   
    public void Execute()
    {
        GameObject G = Instantiate(new GameObject(), new Vector3(transform.position.x, transform.position.y + 1), Quaternion.identity);
        G.transform.gameObject.AddComponent<SpriteRenderer>();
        G.GetComponent<SpriteRenderer>().sprite = Grass;
        G.GetComponent<SpriteRenderer>().sortingOrder = 100;
    }
  

    
}
