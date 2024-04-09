using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Teleport : MonoBehaviour
{


    public Transform player, destination;
    public CharacterController controller;
    
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            controller.enabled = false;
            player.position = destination.position;
            controller.enabled = true;
            Debug.Log("teleported");
        }
    }

    

}
