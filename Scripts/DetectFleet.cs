using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFleet : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartGame.fleetCollided = true;
            StartGame.paused = true;
        }
    }
}
