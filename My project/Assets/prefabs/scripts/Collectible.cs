using UnityEngine;

public class Collectible : MonoBehaviour
{
    [Header("Settings")]
    public string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that touched this is the player
        if (other.CompareTag(playerTag))
        {
            // Optional: You can add points here later via a Game Manager
            // e.g., FindObjectOfType<GameManager>().AddScore(1);

            // Destroy the collectible object (makes it disappear)
            Destroy(gameObject);
        }
    }
}