using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepController : MonoBehaviour
{
    public int Step = 1;
    public string targetTag;
    public Transform parentObject;
    void Start()
    {
        targetTag = "Step 0" + Step;        
    }

    // Update is called once per frame
    void Update()
    {
        targetTag = "Step 0" + Step;
        foreach (Transform child in parentObject)
        {
            // Check if the child's tag is targetTag
            if (child.CompareTag(targetTag))
            {
                child.gameObject.SetActive(true);
            }
        }
    }
    public void increaseValue()
    {
        if(Step < 3)
        {
            Step++;
        }
        
    }
}
