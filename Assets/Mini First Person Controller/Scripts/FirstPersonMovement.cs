using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 2f;
    public float health;
    private int find = 6;
    [Header("Running")]
    public bool canRun = true;
    public bool IsRunning { get; private set; }
    public float runSpeed = 3.3f;
    public KeyCode runningKey = KeyCode.LeftShift;
    Rigidbody rigidbody1;

    GameObject pause;
    /// <summary> Functions to override movement speed. Will use the last added override. </summary>
    public List<System.Func<float>> speedOverrides = new List<System.Func<float>>();



    void Awake()
    {
        health = 4;
        speed = 2f;
        runSpeed = 3.3f;
        // Get the rigidbody on this.
        rigidbody1 = GetComponent<Rigidbody>();
        rigidbody1.AddForce(transform.up * 40f);
    }
    void Start()
    {
        pause = GameObject.FindGameObjectWithTag("pause");
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        if(find <= 0)
        {
            SceneManager.LoadScene(3);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause.GetComponent<AudioSource>().Play();
            events.TrigerPausePlay(Time.timeScale != 0);
            pause.GetComponent<CanvasGroup>().alpha = Time.timeScale == 0 ? 1.0f : 0f ;
        }

    }
    void FixedUpdate()
    {

        if(health <= 0)
        {
            events.gameover();
        }

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
    public void collect(string name)
    {
        GameObject.Find(name+"-1").GetComponent<CanvasGroup>().alpha = 1f;
        find--;
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("enemy"))
        {
            health--;
            Debug.Log(health);
        }
    }
}