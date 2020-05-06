using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandGeneration : MonoBehaviour, IBlockAddon
{
    public Sprite Sand;
    public void Execute()
    {
        gameObject.name = "Sand(Clone)";
        GetComponent<SpriteRenderer>().sprite = Sand;
    }
}
