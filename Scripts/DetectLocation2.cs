using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLocation2 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartGame.location2Collided = true;
            StartGame.paused = true;
        }
        }
}
