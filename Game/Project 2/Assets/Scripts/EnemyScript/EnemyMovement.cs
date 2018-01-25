using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour 
{
    private NavMeshAgent agent;
    private Transform player;
	
	void Start () 
	{
        agent = this.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	
	void Update () 
	{
        agent.SetDestination(player.position);
	}
}
