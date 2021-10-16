using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLocation4 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartGame.location4Collided = true;
            StartGame.paused = true;
        }
    }
}
