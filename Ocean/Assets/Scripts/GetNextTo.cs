using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GetNextTo : MonoBehaviour
{
    public E_GetNextTo Dir;
    public bool b_MaskObjectUse;
    public string[] MaskObject;
    public UnityEvent UE;
    public int Seconds;

    
    public void RayOut()
    {
        if (!b_MaskObjectUse)
        {
            if (Dir == E_GetNextTo.Up)
            {
                RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y + 1f), transform.up * 1);
                if (R)
                {
                    if (R.transform.GetComponent<SpriteRenderer>() != null)
                    {
                        UE.Invoke();
                    }
                }
                else
                {
                    return;
                }
            }
            if (Dir == E_GetNextTo.Down)
            {
                RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y - 1f), -transform.up * 1);
                if (R)
                {
                    UE.Invoke();
                }
            }
            if (Dir == E_GetNextTo.Left)
            {
                RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x + 1, transform.position.y), -transform.right * 1);
                if (R.transform.GetComponent<SpriteRenderer>() != null)
                {
                    UE.Invoke();
                }
            }
            if (Dir == E_GetNextTo.Right)
            {
                RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x - 1, transform.position.y), transform.right * 1);
                if (R.transform.GetComponent<SpriteRenderer>() != null)
                {
                    UE.Invoke();
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
                    for (int i = 0; i < MaskObject.Length; i++)
                    {
                        if (R.transform.name == MaskObject[i])
                        {
                            UE.Invoke();
                            Debug.Log(R.transform.gameObject);
                        }
                    }
                }
            }
            if (Dir == E_GetNextTo.Down)
            {
                RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y - 1f), transform.up * 1);
                if (R)
                {
                    for (int i = 0; i < MaskObject.Length; i++)
                    {
                        if (R.transform.name == MaskObject[i])
                        {
                            UE.Invoke();
                            Debug.Log(R.transform.gameObject);
                        }
                    }
                }
            }
            if (Dir == E_GetNextTo.Left)
            {
                RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x + 1f, transform.position.y), transform.up * 1);
                if (R)
                {
                    for (int i = 0; i < MaskObject.Length; i++)
                    {
                        if (R.transform.name == MaskObject[i])
                        {
                            UE.Invoke();
                            Debug.Log(R.transform.gameObject);
                        }
                    }
                }
            }
            if (Dir == E_GetNextTo.Right)
            {
                RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x - 1f, transform.position.y), transform.up * 1);
                if (R)
                {
                    for (int i = 0; i < MaskObject.Length; i++)
                    {
                        if (R.transform.name == MaskObject[i])
                        {
                            UE.Invoke();
                            Debug.Log(R.transform.gameObject);
                        }
                    }
                }
            }
        }
    }
    public GameObject RayGet()
    {
        if (Dir == E_GetNextTo.Up)
        {
            RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y + 1f), transform.up * 1);
            if (R)
            {
                return R.transform.gameObject;
            }
            else
            {
                return new GameObject();
            }
        }
        else if (Dir == E_GetNextTo.Down)
        {
            RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y - 1f), -transform.up * 1);
            if (R)
            {
                return R.transform.gameObject;
            }
            else
            {
                return new GameObject();
            }
        }
        else if (Dir == E_GetNextTo.Left)
        {
            RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x + 1, transform.position.y), -transform.right * 1);
            if (R)
            {
                return R.transform.gameObject;
            }
            else
            {
                return new GameObject();
            }
        }
        else if (Dir == E_GetNextTo.Right)
        {
            RaycastHit2D R = Physics2D.Raycast(new Vector3(transform.position.x - 1, transform.position.y), transform.right * 1);
            if (R)
            {
                return R.transform.gameObject;
            }
            else
            {
                return new GameObject();
            }
        }
        else
        {
            return new GameObject();
        }
    }
    public IEnumerator WaitForRay()
    {
        yield return new WaitForSeconds(Seconds);
        RayOut();
    }
}
public enum E_GetNextTo { Up, Down, Left, Right}
