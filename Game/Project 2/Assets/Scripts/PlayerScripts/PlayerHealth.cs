using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour 
{
    public float health;
    public int deathScene;


    void OnCollisionEnter (Collision c)
    {
        if (c.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(deathScene);
        }
    }
}
