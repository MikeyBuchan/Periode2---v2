using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 movement;
    public float movSpeed;
    public float sprintSpeedMultiplier;

    private Rigidbody playerRig;
    public Vector3 jumpVelocity;
    public int jumpAmount;
    public int allowedJumpAmount;
    

    void Start()
    {
        playerRig = GetComponent<Rigidbody>();
    }


    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
        transform.Translate(movement * movSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Sprint"))
        {
            movSpeed = movSpeed * sprintSpeedMultiplier;
        }
        if (Input.GetButtonUp("Sprint"))
        {
            movSpeed = movSpeed / sprintSpeedMultiplier;
        }

        if (Input.GetButtonDown("Jump") && jumpAmount >=1)
        {
            playerRig.velocity = jumpVelocity;
            jumpAmount -= 1;
        }
    }

    void OnCollisionEnter(Collision c)
    {
        jumpAmount = allowedJumpAmount;
    }
}
