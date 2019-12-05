using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5.0f;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        // playerRb.AddForce(Vector3.forward * forwardInput * speed);
        // playerRb.AddForce(Vector3.right * horizontalInput * speed);
        playerRb.velocity = (transform.forward * forwardInput * speed * Time.deltaTime);
        playerRb.velocity = (transform.right * horizontalInput * speed * Time.deltaTime);
    }


}