using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectOeger : MonoBehaviour {

	void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartGame.oegerCollided = true;
            StartGame.paused = true;
        }
    }
}
