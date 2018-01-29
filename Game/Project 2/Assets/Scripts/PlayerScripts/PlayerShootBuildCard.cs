using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootBuildCard : MonoBehaviour
{
    public GameObject buildCard;
    public Vector3 shootPos;
    public Quaternion shootRot;
    public bool allowedToShoot = true;
    public float shootAfterSeconds;
    private float timer;
	

	void Update ()
    {
        if (allowedToShoot == false)
        {
            timer += Time.deltaTime;

            if (timer >= shootAfterSeconds)
            {
                allowedToShoot = true;
                timer = 0;
            }
        }

        if (allowedToShoot == true && Input.GetButtonDown("Fire1"))
        {
                shootRot = GameObject.FindWithTag("MainCamera").transform.rotation;
                shootPos = GameObject.FindWithTag("MainCamera").transform.position;
                Instantiate(buildCard, shootPos, shootRot);
                allowedToShoot = false;
        }
	}
}
