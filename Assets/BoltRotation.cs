using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltRotation : MonoBehaviour
{
    public float rotationSpeed = 500f;
    public bool isDrilling = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drill"))  // Check if the colliding object is the drill
        {
            isDrilling = true;
            Debug.Log("Drill has started interacting with the bolt.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Drill"))
        {
            isDrilling = false;
            Debug.Log("Drill has stopped interacting with the bolt.");
        }
    }

    private void Update()
    {
        if (isDrilling)
        {
            // Rotate the bolt while drilling
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
            transform.position += new Vector3(0, 0.0001f, 0);
            Debug.Log("Bolt is rotating...");
        }
    }
}

