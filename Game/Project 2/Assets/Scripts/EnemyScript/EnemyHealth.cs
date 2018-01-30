using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour 
{
    public int hp = 100;
    public GameObject deathParticle;
    public GameObject spawner;

    void Update ()
    {
        if (hp <= 0)
        {
            GameObject.FindWithTag("EnemySpawner").GetComponent<EnemySpawner>().enemiesLeft -= 1;
            //Instantiate(deathParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "DamageCard")
        {
            hp -= Random.Range(15, 30);
        }
    }
}
