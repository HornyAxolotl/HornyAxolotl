using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class GhostMovement : MonoBehaviour
{


    public Transform Present;
    public Vector3 offset;

    private bool IsPresent;


    // Start is called before the first frame update
    private void Start()
    {
        IsPresent = true;
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown("q"))
        {
            if(IsPresent)
            {
                StartCoroutine ("TimeHold");
                IsPresent = false;
            }
            else
            {
                StartCoroutine ("TimeHold");
                IsPresent = true;
            }
        }

        if(IsPresent)
        {
        transform.position = Present.position + offset;
        transform.rotation = Present.rotation;
        }

        else
        {
        transform.position = Present.position - offset;
        transform.rotation = Present.rotation;
        }
    }


    IEnumerator TimeHold()
    {
        yield return new WaitForSeconds (0.0166f);
        Debug.Log("TimeHolded");
    }


}
