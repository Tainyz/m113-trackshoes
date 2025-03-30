using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LoadImages : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // Assign in Inspector
    public Sprite[] spriteArray; // Drag & drop your sprites in the Inspector
    private int currentIndex = 0;
    
    //private string targetTag;
    //public Transform parentObject;


    public void ChangeSprite()
    {
        if (spriteArray.Length == 0 || currentIndex >= spriteArray.Length ) return; // Stop at last sprite
        spriteRenderer.sprite = spriteArray[currentIndex];
        //targetTag = "Step 0" + currentIndex;
        //foreach (Transform child in parentObject)
        //{
        //    // Check if the child's tag is targetTag
        //    if (child.CompareTag(targetTag))
        //    {
        //        MonoBehaviour script = child.GetComponent<assemblyStep>();
        //        if (script != null)
        //        {
        //            script.enabled = true; // Activate the script
        //        }
        //    }
        //}

        currentIndex++;
        

    }
}
