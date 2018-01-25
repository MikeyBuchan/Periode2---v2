using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCursor : MonoBehaviour 
{
    private bool hidCursor;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (hidCursor == true)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                hidCursor = false;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                hidCursor = true;
            }
        }
    }
}
