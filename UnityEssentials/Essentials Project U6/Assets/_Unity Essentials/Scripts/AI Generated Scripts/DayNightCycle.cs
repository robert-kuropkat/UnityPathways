// 11/7/2024 AI-Tag
// This was created with assistance from Muse, a Unity Artificial Intelligence product

using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Duration in seconds for a full day cycle
    [SerializeField]
    private float dayDurationInSeconds = 120f; // Default to 2 minutes

    private float rotationSpeed;

    void Start()
    {
        // Calculate rotation speed based on day duration
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    void Update()
    {
        // Rotate the light around the x-axis
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}