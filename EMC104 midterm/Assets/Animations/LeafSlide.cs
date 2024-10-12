using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SlideUpDown : MonoBehaviour
{
    public Button toggleButton;                // Reference to the UI button
    public RectTransform slidingPanel;         // Reference to the panel that will slide
    public float slideDistance = 300f;         // Distance to slide up or down
    public float slideDuration = 0.5f;         // Duration of the slide

    private bool isVisible = true;            // Track the visibility state

    void Start()
    {

        // Add the ToggleSlide method as a listener for the button click event
        toggleButton.onClick.AddListener(ToggleSlide);
    }

    // Method to toggle the slide animation
    void ToggleSlide()
    {
        if (isVisible)
        {
            //off screen
            slidingPanel.DOLocalMoveY(-slideDistance, slideDuration).SetEase(Ease.OutBack);

            
        }
        else
        {
            // on screen
            slidingPanel.DOLocalMoveY(0f, slideDuration).SetEase(Ease.OutBack);
        }

        // Toggle visibility state
        isVisible = !isVisible;
    }
}
