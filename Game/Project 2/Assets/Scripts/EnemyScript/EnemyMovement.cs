using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour 
{
    public Vector3 mov;
    public float movSpeed;
    public Transform player;
	

    void Start ()
    {
        mov.z = 1;
    }
	
	void Update () 
	{
        transform.LookAt(player);
        transform.Translate(mov * movSpeed * Time.deltaTime,Space.Self);
	}
}
