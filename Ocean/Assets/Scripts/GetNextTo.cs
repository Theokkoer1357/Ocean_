using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetNextTo : MonoBehaviour
{
    public E_GetNextTo Dir;
    public bool b_MaskObjectUse;
    public string MaskObject;

    
    public void RayOut()
    {
        
    }
    public void Start()
    {
        if (b_MaskObjectUse)
        {
            if (Dir == E_GetNextTo.Up)
            {
                RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y + 1f), transform.up * 1);
                if (R)
                {
                    if (R.transform.GetComponent<SpriteRenderer>() != null)
                    {
                        R.transform.gameObject.SetActive(false);
                    }
                }
            }
            if (Dir == E_GetNextTo.Down)
            {
                RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y - 1f), transform.up * 1);
                if (R.transform.GetComponent<SpriteRenderer>() != null)
                {
                    R.transform.gameObject.SetActive(false);
                }
            }
            if (Dir == E_GetNextTo.Left)
            {
                RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x + 1, transform.position.y), transform.up * 1);
                if (R.transform.GetComponent<SpriteRenderer>() != null)
                {
                    R.transform.gameObject.SetActive(false);
                }
            }
            if (Dir == E_GetNextTo.Right)
            {
                RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x - 1, transform.position.y), transform.up * 1);
                if (R.transform.GetComponent<SpriteRenderer>() != null)
                {
                    R.transform.gameObject.SetActive(false);
                }
            }
        }
        else
        {
            if (Dir == E_GetNextTo.Up)
            {
                RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y + 1f), transform.up * 1);
                if (R)
                {
                    Debug.Log(R.transform.gameObject);
                    if (R.transform.name == MaskObject)
                    {
                        Debug.Log("eeeeeeee");

                        R.transform.gameObject.SetActive(false);
                    }
                }
            }
            if (Dir == E_GetNextTo.Down)
            {
                RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y - 1f), transform.up * 1);
                if (R)
                {
                    if (R.transform.name == MaskObject)
                    {
                        R.transform.gameObject.SetActive(false);
                    }
                }
            }
            if (Dir == E_GetNextTo.Left)
            {
                RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x + 1f, transform.position.y), transform.up * 1);
                if (R)
                {
                    if (R.transform.name == MaskObject)
                    {
                        R.transform.gameObject.SetActive(false);
                    }
                }
            }
            if (Dir == E_GetNextTo.Right)
            {
                RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x - 1f, transform.position.y), transform.up * 1);
                if (R)
                {
                    if (R.transform.name == MaskObject)
                    {
                        R.transform.gameObject.SetActive(false);
                    }
                }
            }
        }
    }
    
}
public enum E_GetNextTo { Up, Down, Left, Right}
