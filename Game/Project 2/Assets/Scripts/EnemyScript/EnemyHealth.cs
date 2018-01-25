﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour 
{
    public int hp = 100;
    public GameObject deathParticle;


    void Update ()
    {
        if (hp <= 0)
        {
            Destroy(gameObject, .3f);
            Instantiate(deathParticle, transform.position, Quaternion.identity);
        }
    }
}