using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardShootBuild : MonoBehaviour
{
    private Vector3 blockPos;
    public Vector3 v;
    public Quaternion wallSpawnRotation;
    public Quaternion wallRot;
    public GameObject buildWall;
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
            wallRot = new Quaternion(0, transform.rotation.y, 0,transform.rotation.w);
            blockPos = transform.position;
            Instantiate(buildWall, blockPos, wallRot);
            Destroy(gameObject);
        }
    }
}
