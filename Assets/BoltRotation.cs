using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltRotation : MonoBehaviour
{
    public float rotationSpeed = 500f;
    public bool isDrilling = false;
    public Transform wrench;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drill"))  // Check if the colliding object is the drill
        {
            isDrilling = true;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Drill"))
        {
            isDrilling = false;
            
        }
    }

    private void Update()
    {
        if (isDrilling)
        {
            // Rotate the bolt while drilling
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
            transform.position += new Vector3(0, 0.0001f, 0);
            

        }
    }
}

