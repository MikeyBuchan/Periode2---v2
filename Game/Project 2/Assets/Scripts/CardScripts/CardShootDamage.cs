using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardShootDamage : MonoBehaviour
{
    private float timer;
    public Vector3 movement;
    public float speed;
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

    private void OnCollisionEnter(Collision c)
    {
            Destroy(gameObject);
    }
}
