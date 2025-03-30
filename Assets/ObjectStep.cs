using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectStep : MonoBehaviour
{
    public int Step = 0;
    private string targetTag;
    public Transform parentObject;
    // Start is called before the first frame update
    void Start()
    {
        targetTag = "Step 0" + Step;
        Debug.Log("FirstTag"+targetTag);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform child in parentObject)
        {
            // Check if the child's tag is targetTag

            targetTag = "Step 0" + Step;
            Debug.Log(targetTag);
            if (child.CompareTag(targetTag))
            {
                MonoBehaviour script = child.GetComponent<assemblyStep>();
                if (script != null)
                {
                    script.enabled = true; // Activate the script
                }
            }            
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
