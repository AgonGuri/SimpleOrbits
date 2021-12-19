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
        transform.position =
    RotatePointAroundPivot(transform.position,
                           transform.parent.position,
                           Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0));
    }

    public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion angle)
    {
        return angle * (point - pivot) + pivot;
    }
}
