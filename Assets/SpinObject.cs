using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour
{
    // Public variable to control speed of rotation
    public float spinSpeed = 100f;

    void Update()
    {
        // Rotate the object around its Y-axis
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }
}

