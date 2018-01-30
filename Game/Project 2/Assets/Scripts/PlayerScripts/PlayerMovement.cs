using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 movement;
    public float movSpeed;
    public float sprintSpeed;
    public float defaultSpeed;

    private Rigidbody playerRig;
    public Vector3 jumpVelocity;
    public int jumpAmount;
    public int allowedJumpAmount;
    

    void Start()
    {
        playerRig = GetComponent<Rigidbody>();
        movSpeed = defaultSpeed;
    }


    void FixedUpdate()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
        transform.Translate(movement * movSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && jumpAmount >=1)
        {
            playerRig.velocity = jumpVelocity;
            jumpAmount -= 1;
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Sprint"))
        {
            movSpeed = sprintSpeed;
        }
        if (Input.GetButtonUp("Sprint"))
        {
            movSpeed = defaultSpeed;
        }
    }

    void OnCollisionEnter(Collision c)
    {
        jumpAmount = allowedJumpAmount;
    }
}
