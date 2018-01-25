using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCardShoot : MonoBehaviour
{
    private Vector3 blockPos;
    public GameObject buildWall;
    public Vector3 v;
    public Quaternion blockRot;
    public float speed;
    public float timer;
    public float destroyOnTime;


    void Update()
    {
        Destroy(gameObject, destroyOnTime);

        transform.Translate(v * speed * Time.deltaTime, Space.Self);
    }


    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Ground")
        {
            blockPos = transform.position;
            Instantiate(buildWall, blockPos, buildWall.transform.rotation);
            Destroy(gameObject);
        }

        if (c.gameObject.tag == "BuildCube")
        {
            blockPos = transform.position;
            Instantiate(buildWall, blockPos, blockRot);
            Destroy(gameObject);
        }
    }
}
