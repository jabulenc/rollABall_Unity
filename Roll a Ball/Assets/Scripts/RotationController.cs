using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // Frame independent rotation
        // Time.deltaTime is the amount of time it took to complete the last frame
        // The vector3 represents... a 3d vector
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
