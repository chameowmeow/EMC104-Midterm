using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class LeafShake : MonoBehaviour
{
    public Button shakeButton;  // Reference to the UI button
    public float shakeDuration = 1f;  // Duration of the shake
    public float strength = 1f;       // Strength of the shake
    public int vibrato = 10;          // How much the object vibrates
    public float randomness = 90f;    // Randomness of the shake

    void Start()
    {
        // Add the ToggleShake method as a listener for the button click event
        shakeButton.onClick.AddListener(ToggleShake);
    }

    // Method to toggle the shake animation
    void ToggleShake()
    {
        // Perform a shake with specified parameters
        transform.DOShakePosition(shakeDuration, strength, vibrato, randomness);
    }
}
