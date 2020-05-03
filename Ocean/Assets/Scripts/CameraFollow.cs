using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public void Update()
    {
        Camera.main.transform.position = transform.position;
    }
}
