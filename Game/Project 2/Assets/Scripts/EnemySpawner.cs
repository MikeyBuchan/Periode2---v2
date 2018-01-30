using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour 
{
    public Quaternion spawnRotation;
    public Vector3 spawnLocation;
    public GameObject enemy;
    public int enemiesLeft;
    public bool spawnNextWave = false;

    public int spawnEnemies;
    public Transform[] enemySpawnLoc;

    void Start()
    {
        spawnLocation = transform.position;
    }

    void Update()
    {
        if (enemiesLeft <= 0)
        {
            if (Input.GetButtonDown("NextWave"))
            {
                spawnNextWave = true;
            }

        }

        if (spawnNextWave == true)
        {
            enemiesLeft = spawnEnemies;
            spawnNextWave = false;
            for (int i = 0; i < spawnEnemies; i++)
            {
                Instantiate(enemy, enemySpawnLoc[Random.Range(0,4)].position, spawnRotation);
            }
            spawnEnemies += 3;
        }
    }
}
