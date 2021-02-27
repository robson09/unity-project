using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(Rigidbody))]
public class PlayerBehaviour : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    private float horizontalInput;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Move();
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        }
    }

    void Move()
    {
        float yAxisMovement = rb.velocity.y; 
        horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(horizontalInput, yAxisMovement, 0);
        
    }
}
