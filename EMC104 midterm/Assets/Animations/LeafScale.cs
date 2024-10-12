using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using Unity.VisualScripting;
public class LeafScale : MonoBehaviour
{
    public float targetScale = 2f; 
    public float originalScale = 1; 
    public float duration = 1f;   
    public Button scaleButton;      

    private bool isScaledUp = true;  // Tracking the scale

    void Start() {
        // Link the button's onClick event to the ToggleScale method
        scaleButton.onClick.AddListener(ToggleScale);
    }

    // Scaling up and scaling down
    void ToggleScale()
    {
        if (isScaledUp)
        {
            
            transform.DOScale(originalScale, duration).SetEase(Ease.OutQuad);
        }
        else
        {
            
            transform.DOScale(targetScale, duration).SetEase(Ease.OutQuad);
        }

        // Toggle the flag
        isScaledUp = !isScaledUp;
    }
}