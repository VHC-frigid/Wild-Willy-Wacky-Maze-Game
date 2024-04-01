using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 180f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Movement input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized * moveSpeed * Time.deltaTime;

        // Apply movement
        rb.MovePosition(transform.position + transform.TransformDirection(movement));

        // Rotation input
        float mouseX = Input.GetAxis("Mouse X");

        // Calculate rotation
        float rotationAmount = mouseX * rotationSpeed * Time.deltaTime;

        // Apply rotation
        transform.Rotate(Vector3.up, rotationAmount);
    }
}
