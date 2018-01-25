using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour 
{
    private float timer;
    public float spawnOnSeconds;
    public GameObject enemy;
    public Vector3 spawnLocation;
    public Quaternion spawnRotation;

    void Start()
    {
        spawnLocation = transform.position;
    }

    void Update () 
	{
        timer += Time.deltaTime;

        if (timer >= spawnOnSeconds)
        {
            timer = 0;
            Instantiate(enemy, spawnLocation, spawnRotation);
        }
	}
}
