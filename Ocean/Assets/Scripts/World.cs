using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    public static World TheWorld;
    public int size;
    public Texture2D WorldText;

    public void Awake()
    {
        if(TheWorld == null)
        {
            TheWorld = this;
        }
    }
}
