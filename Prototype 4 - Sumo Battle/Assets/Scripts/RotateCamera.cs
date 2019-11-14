using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotatationSpeed;
    private float horizontalInput;
    void Start()
    {
        
    }

    void Update()
    {
        
        // horizontalInput = Input.GetAxis("Horizontal");
        // transform.Rotate(Vector3.up, horizontalInput * rotatationSpeed * Time.deltaTime);
        // if (Input.GetKey(Input.mousePosition))
        {
            // transform.Rotate(Vector3.up * rotatationSpeed * Time.deltaTime);
        }
        
    }
    voice OnMouseDrag
    {
        transform.Rotate(Vector3.up * rotatationSpeed * Time.deltaTime);
    }
}
