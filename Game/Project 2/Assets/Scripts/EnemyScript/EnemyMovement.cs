using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour 
{
    public Vector3 mov;
    public float movSpeed;
    public Transform player;
	
	
	void Update () 
	{
        transform.LookAt(player);
        transform.Translate(transform.forward * movSpeed * Time.deltaTime);
	}
}
