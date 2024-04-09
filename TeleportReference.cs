using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportReference : MonoBehaviour
{
    public Transform reference, destination;
    public CharacterController controller;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                StartCoroutine("Tipi");
            }
        }
    }


    IEnumerator Tipi()
    {
        yield return new WaitForSeconds(0.01666f);
        controller.enabled = false;
        reference.position = destination.position;
        controller.enabled = true;
        Debug.Log("teleported reference");
    }

    
}

