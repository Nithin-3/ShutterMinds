using System;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 2f;

    [Header("Running")]
    public bool canRun = true;
    public bool IsRunning { get; private set; }
    public float runSpeed = 3.3f;
    public KeyCode runningKey = KeyCode.LeftShift;
    Rigidbody rigidbody1;
    /// <summary> Functions to override movement speed. Will use the last added override. </summary>
    public List<System.Func<float>> speedOverrides = new List<System.Func<float>>();



    void Awake()
    {
        speed = 2f;
        runSpeed = 3.3f;
        // Get the rigidbody on this.
        rigidbody1 = GetComponent<Rigidbody>();
        rigidbody1.AddForce(transform.up * 40f);
    }

    void FixedUpdate()
    {
        Cursor.lockState = CursorLockMode.None;
        // Update IsRunning from input.
        IsRunning = canRun && Input.GetKey(runningKey);

        // Get targetMovingSpeed.
        float targetMovingSpeed = IsRunning ? runSpeed : speed;
        /*if (speedOverrides.Count > 0)
        {
            targetMovingSpeed = speedOverrides[speedOverrides.Count - 1]();
        }*/

        // Get targetVelocity from input.
        Vector2 targetVelocity =new Vector2( Input.GetAxis("Horizontal") * targetMovingSpeed, Input.GetAxis("Vertical") * targetMovingSpeed);

        // Apply movement.
        
        rigidbody1.velocity = transform.rotation * new Vector3(targetVelocity.x, rigidbody1.velocity.y, targetVelocity.y);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log(collision.gameObject.name);
    }
}