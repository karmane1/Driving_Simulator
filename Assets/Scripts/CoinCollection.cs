using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import TextMeshPro namespace

public class CoinCollection : MonoBehaviour
{
    private int coinCount = 0;
    public TextMeshProUGUI coinText;

    // This method is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider's tag is "Coins"
        if (other.CompareTag("Coins"))
        {
            coinCount++; // Increment coin count
            coinText.text = "Coins : " + coinCount.ToString(); // Update UI text
            Debug.Log("Coins collected: " + coinCount); // Log the current coin count
            Destroy(other.gameObject); // Destroy the collected coin
        }
    }
}
