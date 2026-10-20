
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public GameObject finishUI;

    private void Start()
    {
        finishUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            finishUI.SetActive(true);
        }
    }
}
