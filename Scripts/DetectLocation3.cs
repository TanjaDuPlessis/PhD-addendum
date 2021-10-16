using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLocation3 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartGame.location3Collided = true;
            StartGame.paused = true;
        }
    }
}
