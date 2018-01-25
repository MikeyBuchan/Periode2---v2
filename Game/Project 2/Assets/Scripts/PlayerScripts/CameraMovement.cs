using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 cameraX;
    public Vector3 cameraY;
    public float sensitivity;

	void Start ()
    {
		
	}
	

	void Update ()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
        cameraY.y = Input.GetAxis("Mouse X");
        transform.Rotate(cameraY * sensitivity * Time.deltaTime);

        cameraX.x = -Input.GetAxis("Mouse Y");
        GameObject.FindWithTag("MainCamera").transform.Rotate(cameraX * sensitivity * Time.deltaTime);
    }
}
