using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLocation5 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartGame.location5Collided = true;
            StartGame.paused = true;
        }
    }
}
