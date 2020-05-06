using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Structure")]
public class Structures : ScriptableObject
{
    public Block[] Blocks;
    public string StructName;
}
