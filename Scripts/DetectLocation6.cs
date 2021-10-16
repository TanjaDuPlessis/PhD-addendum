using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLocation6 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartGame.location6Collided = true;
            StartGame.paused = true;
        }
    }
}
