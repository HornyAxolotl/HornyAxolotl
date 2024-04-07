using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{


    public Transform player, destination;
    public GameObject playerg;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            playerg.SetActive(false);
            player.position = destination.position;
            playerg.SetActive(true);
            Debug.Log("teleported");
        }
    }
}
