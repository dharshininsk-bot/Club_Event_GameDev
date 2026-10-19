using UnityEngine;

public class SimpleCarController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 10f;
    public float turnSpeed = 100f;

    void Update()
    {
        // Get input from vertical arrows (W/S or Up/Down arrows)
        float moveInput = Input.GetAxis("Vertical"); // 1 for forward, -1 for backward

        // Get input from horizontal arrows (A/D or Left/Right arrows)
        float turnInput = Input.GetAxis("Horizontal"); // 1 for right, -1 for left

        // Move the car forward or backward based on local Z-axis
        transform.Translate(Vector3.forward * moveInput * moveSpeed * Time.deltaTime);

        // Rotate the car left or right around the Y-axis
        transform.Rotate(Vector3.up * turnInput * turnSpeed * Time.deltaTime);
    }
}