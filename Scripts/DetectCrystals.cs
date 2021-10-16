using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCrystals : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartGame.crystalsCollided = true;
            StartGame.paused = true;
        }
    }
}
