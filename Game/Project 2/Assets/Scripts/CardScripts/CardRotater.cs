using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRotater : MonoBehaviour 
{
    public Vector3 cardRotate;
    public float rotateSpeed;
	
	
	void Update () 
	{
        transform.Rotate(cardRotate * rotateSpeed * Time.deltaTime);
	}
}
