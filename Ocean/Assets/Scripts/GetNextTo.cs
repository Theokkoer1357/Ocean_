using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetNextTo : MonoBehaviour
{
    public E_GetNextTo Dir;

    public void Start()
    {
        if(Dir == E_GetNextTo.Up)
        {
            RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y + 1f), transform.up * 1);
            if (R.transform.GetComponent<SpriteRenderer>() != null)
            {
                R.transform.gameObject.SetActive(false);
            }
        }
        if (Dir == E_GetNextTo.Down)
        {

        }
        if (Dir == E_GetNextTo.Left)
        {

        }
        if (Dir == E_GetNextTo.Right)
        {

        }
    }
    public void Update()
    {
        Debug.DrawRay(new Vector3(transform.position.x, transform.position.y + 1.1f), transform.up * 5);
    }
}
public enum E_GetNextTo { Up, Down, Left, Right}
