using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assemblyStep : MonoBehaviour
{
    
    public Transform hintPlacement; // Assign the hint placement in the inspector
    public float moveSpeed = 1f;
    public float rotationSpeed = 100f;

    private bool isMoving = false;
    private Vector3 targetPosition;
    private Quaternion targetRotation;

    public int Step = 0;
    public string targetTag;

    public GameObject DialogObj;

    // Start is called before the first frame update
    void Start()
    {
        if (DialogObj != null)
        {
            Invoke(nameof(ActivateObject), 1f);

        }
        targetTag = "Step 0" + Step;
        Movingobj();
        
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (isMoving)
        {
            // Smooth position change
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Smooth rotation change using RotateTowards
            gameObject.transform.rotation = Quaternion.RotateTowards(gameObject.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Stop moving when the object is close enough to the target position and rotation
            if (Vector3.Distance(gameObject.transform.position, targetPosition) < 0.1f &&
                Quaternion.Angle(gameObject.transform.rotation, targetRotation) < 1f)
            {
                gameObject.transform.position = targetPosition;
                gameObject.transform.rotation = targetRotation;
                isMoving = false; // Stop the movement
            }
        }

    }
    public void Movingobj()
    {
        if (hintPlacement != null)
        {
            targetPosition = hintPlacement.position;
            targetRotation = hintPlacement.rotation;
            isMoving = true; // Begin the movement
        }
    }
    void ActivateObject()
    {
        DialogObj.SetActive(true);
    }

}
