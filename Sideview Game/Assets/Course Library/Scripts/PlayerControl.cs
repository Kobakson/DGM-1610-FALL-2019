using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 10;
    public float gravityModifier = 1;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.Space))
        {
           playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        }
    }
}
