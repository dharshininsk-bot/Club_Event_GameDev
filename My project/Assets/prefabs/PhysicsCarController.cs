using UnityEngine;

public class PhysicsCarController : MonoBehaviour
{
    private Rigidbody rb;

    [Header("Movement Settings")]
    public float moveSpeed = 10f;
    public float turnSpeed = 100f;

    private float moveInput;
    private float turnInput;

    void Start()
    {
        // Get the Rigidbody component attached to this car
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get legacy input (Arrow keys or W/S/A/D)
        moveInput = Input.GetAxis("Vertical");   // Forward / Backward
        turnInput = Input.GetAxis("Horizontal"); // Left / Right
    }

    void FixedUpdate()
    {
        // 1. Move forward/backward while preserving the Y velocity (so gravity still works)
        Vector3 moveDirection = transform.forward * moveInput * moveSpeed;
        rb.linearVelocity = new Vector3(moveDirection.x, rb.linearVelocity.y, moveDirection.z);

        // 2. Turn the car left or right using physics rotation
        float turn = turnInput * turnSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}