using UnityEngine;
using TMPro;

public class Speedometer : MonoBehaviour
{
    public Rigidbody bikeRigidbody;
    public TextMeshProUGUI speedText;
    
    void Update()
    {
        // Calculate speed based on the rigidbody's velocity
        float speed = bikeRigidbody.velocity.magnitude * 3.6f; // Convert from m/s to km/h
        
        // Update the speed text
        speedText.text = "Speed: " + speed.ToString("F1") + " km/h";
    }
}
