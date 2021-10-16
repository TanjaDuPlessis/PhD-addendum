using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLocation : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartGame.locationCollided = true;
            StartGame.paused = true;
        }
    }
}
