using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // move the x val of the plane away from the cube to the point where there's only a little bit of area left for the cube in the front
    // move the y val of the main camera to get a better view of the cube

    // use the cylinder and the scale tool to change the shape of the cylinder to a coin
    // *OPTIONAL* change the x rotation to 90 under transform
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        // target represents the cube in which the main camera will look at
    }
}
