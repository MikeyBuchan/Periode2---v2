﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float destroyAfterSeconds;

	void Start ()
    {
        Destroy(gameObject, destroyAfterSeconds);
	}
}
