using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// for the Update function, want to be in the clear
// ? 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net
public class Controller : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D R2;
    Vector2 MovePos;
    void Update()
    {
        R2.IsAwake();

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z);

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = Vector3.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), Speed * Time.deltaTime);
            R2.Sleep();
        }
        else
        {
            R2.Sleep();
        }
    }
   
}
