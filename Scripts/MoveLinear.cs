using UnityEngine;
using System.Collections;

public class MoveLinear : MonoBehaviour
{

    
    public AnimationCurve myCurve;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time*50 % myCurve.length)), transform.position.z);
    }
}