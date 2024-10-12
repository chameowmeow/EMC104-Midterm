using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class LeafBounce : MonoBehaviour
{
    public Button toggleButton;                
    public RectTransform slidingPanel;        
    public float slideDistance = 6f;     
    public float slideDuration = 0.5f;       

    private bool isBounce = true;   // Track the bounce 

    void Start() {
        // Add the ToggleBounce method as a listener for the button click event
        toggleButton.onClick.AddListener(ToggleBounce);
    }

    // Method to toggle the bounce animation
    void ToggleBounce() {
        if (isBounce)
        {
            // First bounce down, then back up with a bounce easing effect
            slidingPanel.DOLocalMoveY(-slideDistance, slideDuration).SetEase(Ease.OutBounce)
                .OnComplete(() =>
                {
                    // After sliding down, move it back up
                    slidingPanel.DOLocalMoveY(0f, slideDuration).SetEase(Ease.OutBounce);
                });
        }
        
        // Toggle the bounce state (optional if you want this to trigger once)
        isBounce = !isBounce;
    }
}
