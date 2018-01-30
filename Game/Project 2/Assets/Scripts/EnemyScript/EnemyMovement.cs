using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour 
{
    public Vector3 mov;
    public float movSpeed;
    public Transform playerTransform;
    public GameObject player;
	

    void Start ()
    {
        mov.z = 1;
        player = GameObject.FindWithTag("Player");
        playerTransform = player.transform;
    }
	
	void Update () 
	{
        transform.LookAt(playerTransform);
        transform.Translate(mov * movSpeed * Time.deltaTime,Space.Self);
	}
}
