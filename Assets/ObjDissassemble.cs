using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.XR.OpenXR.Features.Interactions.DPadInteraction;

public class ObjDissassemble : MonoBehaviour
{
    public int Step = 0;
    private string targetTag;
    //Step 1
    public Transform wrench;
    //Step 2
    public Transform trackShoes;
    public float rotationDuration = 2f; // Duration of the rotation in seconds
    private float timeElapsed = 0f;
    //Step 3
    public Transform Pad;
    public Transform Board;
    public GameObject[] OldPad;
    public GameObject[] HintPad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetTag = "Step 0" + Step;
        if (Step == 1)
        {
            wrench.gameObject.SetActive(true);
        }
        if (Step == 2)
        {
            // Increment timeElapsed by time passed since last frame
            timeElapsed += Time.deltaTime;

            // Smoothly rotate from 0 to 90 degrees on the X-axis
            float rotationValue = Mathf.Lerp(0f, 90f, timeElapsed / rotationDuration);

            // Apply the rotation to trackShoes
            trackShoes.transform.rotation = Quaternion.Euler(rotationValue, 0f, 0f);

            // Clamp the value to stop it once 90 degrees is reached
            if (timeElapsed >= rotationDuration)
            {
                timeElapsed = rotationDuration; // Prevent further rotation
            }
        }
        if (Step == 3)
        {
            Pad.gameObject.SetActive(true);
            foreach (GameObject obj in OldPad)
            {
                obj.SetActive(false); 
            }
            foreach (GameObject obj in HintPad)
            {
                obj.SetActive(true);
            }
            Board.gameObject.SetActive(false);
        }
    }
    public void increaseValue()
    {
        if (Step < 4)
        {
            Step++;
        }

    }
}
