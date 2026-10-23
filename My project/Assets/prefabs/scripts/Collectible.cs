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
            CoinManager manager = FindFirstObjectByType<CoinManager>(); 
            if (manager != null) 
                { manager.AddCoin(); }
            // Destroy the collectible object (makes it disappear)
            Destroy(gameObject);
        }
    }
}