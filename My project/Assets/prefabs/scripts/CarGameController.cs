using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CarGameController : MonoBehaviour
{
    public GameObject coinCanvas;
    public TextMeshProUGUI coinText;
    public CoinManager coinManager;
    private float startY;

    void Start()
    {
        startY = transform.position.y;
        if (!coinManager) coinManager = FindFirstObjectByType<CoinManager>();
    }

    void Update()
    {
        // Shows canvas if the car falls/changes Y-axis
        if (Mathf.Abs(transform.position.y - startY) > 1f)
            ShowCanvas();
    }

    void OnTriggerEnter(Collider other)
    {
        // Shows canvas if car reaches end of the road
        if (other.CompareTag("FinishLine"))
            ShowCanvas();
    }

    void ShowCanvas()
    {
        if (coinCanvas && !coinCanvas.activeSelf)
        {
            coinCanvas.SetActive(true);
            if (coinText && coinManager)
                coinText.text = coinManager.coinCount.ToString();
        }
    }

    public void RetryGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
