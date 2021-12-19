using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moonOrbit : MonoBehaviour
{    //devbranch

    public Transform target;
    public float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        // TODO: move not just around the y axis

        transform.position =
    RotatePointAroundPivot(transform.position, // point which has to be moved
                           transform.parent.position, // pivot where to move around
                           Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0)); // angle on which to move around
    }

    public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion angle)
    {
        return angle * (point - pivot) + pivot;
    }
}
