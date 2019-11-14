using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed;
    private GameObject focalPoint; 

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    void Update()
    {
        float fwInput = Input.GetAxis("Vertical");
        float swInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(focalPoint.transform.forward * speed * fwInput);
        playerRb.AddForce(focalPoint.transform.right * speed * swInput);
        // float fwInput = Input.GetAxis("Vertical");
        // playerRb.AddForce(focalPoint.transform.forward * speed * fwInput);
    }
}
