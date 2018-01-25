using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCardShoot : MonoBehaviour
{
    private float timer;
    public Vector3 movement;
    public float speed;
    public float destroyOnTime;
    public GameObject enemy;
    public int damage;
    

	void Update ()
    {
        timer += Time.deltaTime;
        if (timer >= destroyOnTime)
        {
            Destroy(gameObject);
        }

        transform.Translate(movement * speed * Time.deltaTime, Space.Self);
	}

    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Enemy")
        {
            c.gameObject.GetComponent<EnemyHealth>().hp -= damage;
            Destroy(gameObject);
        }
    }
}
