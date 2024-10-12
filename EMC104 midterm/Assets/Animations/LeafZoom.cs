using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using Unity.VisualScripting;
public class LeafZoom : MonoBehaviour
{
    public float targetScale = 2f; 
    public float originalScale = 0; 
    public float duration = .5f;   
    public Button zoomButton;      

    private bool isZoomedIn = true;  // Tracking the scale

    void Start() {
        // Link the button's onClick event to the ToggleScale method
        zoomButton.onClick.AddListener(ToggleScale);
    }

    // Scaling up and scaling down
    void ToggleScale()
    {
        if (isZoomedIn)
        {
            
            transform.DOScale(originalScale, duration).SetEase(Ease.OutQuint);
        }
        else
        {
            
            transform.DOScale(targetScale, duration).SetEase(Ease.OutQuint);
        }

        // Toggle the flag
        isZoomedIn = !isZoomedIn;
    }
}