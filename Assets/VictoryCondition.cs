using UnityEngine;

public class VictoryCondition : MonoBehaviour
{
    public Transform xrOrigin; // Reference to XR Origin
    public Vector3 targetCoordinates = new Vector3(165.6f, 31.26f, 251.7f); // Exact target coordinates
    public Canvas winningCanvas; // Reference to the Canvas that is your winning screen
    public float tolerance = 0.1f; // Small tolerance to allow for slight imprecision

    void Update()
    {
        // Check if the player is within the tolerance range of the exact target coordinates
        if (Mathf.Abs(xrOrigin.position.x - targetCoordinates.x) < tolerance &&
            Mathf.Abs(xrOrigin.position.y - targetCoordinates.y) < tolerance &&
            Mathf.Abs(xrOrigin.position.z - targetCoordinates.z) < tolerance)
        {
            winningCanvas.gameObject.SetActive(true); // Activate the winning screen
        }
    }
}
