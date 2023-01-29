using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControllerScript : MonoBehaviour
{
    public GameObject controller;
   
    public float rotationSpeed = 1f;

    void OnMouseDrag()
    {
        if (Input.GetMouseButton(0))
        {
            float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
            float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;

            transform.Rotate(Vector3.down, XaxisRotation, Space.World);
            transform.Rotate(Vector3.right, YaxisRotation, Space.World);
        }

    }
}
