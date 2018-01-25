using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCardShoot : MonoBehaviour
{
    public Vector3 movement;
    public float speed;
    public float timer;
    public float destroyOnTime;
    
    
	void Update ()
    {
        timer += Time.deltaTime;
        if (timer >= destroyOnTime)
        {
            Destroy(gameObject);
        }

        transform.Translate(movement * speed * Time.deltaTime, Space.Self);
	}


    void OnCollisionEnter(Collision c)
    {
        speed = 0;
        Destroy(GetComponent<Rigidbody>());
    }
}
