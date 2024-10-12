using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class LeafFlip : MonoBehaviour {
    public Button flipButton;               // Reference to the UI button
    public float flipDuration = 0.5f;      
    public float flipAngle = 180f;          

    private bool isFlipped = false;        


    void Start()
    {
        flipButton.onClick.AddListener(Flip);
    }

    void Flip() {

        if (isFlipped) 
        {
            // Rotate back to original position
            transform.DORotate(Vector3.zero, flipDuration).SetEase(Ease.OutBack);
        }
        else 
        {
            // Rotate to the specified flip angle
            transform.DORotate(new Vector3(0, flipAngle, 0), flipDuration, RotateMode.WorldAxisAdd)
                     .SetEase(Ease.OutBack);   // Optional: Set an easing function
        }

        // Toggle flip
        isFlipped = !isFlipped;  
    }
}
