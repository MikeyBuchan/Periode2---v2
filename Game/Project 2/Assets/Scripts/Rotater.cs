using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour 
{
    public Vector3 rotateDir;
    public float rotateSpeed;
	
	
	void Update () 
	{
        transform.Rotate(rotateDir * rotateSpeed * Time.deltaTime);
	}
}
