using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public Texture2D t;
    public void Start()
    {
        MapTopGenerate();
    }
    public void MapTopGenerate()
    {
        Texture2D T = new Texture2D(30, 30);
        List<float> BedHights = new List<float>();
        for (int i = 0; i < 30; i++)
        {
            float f = Mathf.Sin(Random.Range(0,1.5f) * Time.deltaTime) * 100;
            T.SetPixel(i, Mathf.RoundToInt(f), new Color(255, 255, 255));
            for (int j = 0; j < 29 - Mathf.RoundToInt(f); j++)
            {
                T.SetPixel(i, j, new Color(255, 255, 255));
            }
           
            BedHights.Add(f);
            Debug.Log(f);
        }
        T.Apply();
        t = T;
        t.Apply();
        t.filterMode = FilterMode.Point;
        GameObject G = GameObject.CreatePrimitive(PrimitiveType.Plane);
        G.GetComponent<MeshRenderer>().material.mainTexture = t;
        G.transform.Rotate(new Vector3(-90, 0, 0));
    }
}
