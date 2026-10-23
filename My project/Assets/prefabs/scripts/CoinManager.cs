using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public int coinCount = 0;
    public TextMeshProUGUI coinText;

    public void AddCoin()
    {
        coinCount++;
        coinText.text = "Coins: " + coinCount;
    }
}