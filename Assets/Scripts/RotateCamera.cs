using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    Quaternion originRotation;
    float angelHorizontal;
    float angelVertical;
    float mouseSens = 1f;
    
    void Start()
    {
        originRotation = transform.rotation;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
       // bool isWalking = false;

        angelHorizontal += Input.GetAxis("Mouse X") * mouseSens;
        angelVertical += Input.GetAxis("Mouse Y") * mouseSens;

        angelVertical = Mathf.Clamp(angelVertical, -10, 30);
       // angelHorizontal = Mathf.Clamp(angelHorizontal, -60, 60);

        Quaternion rotationX = Quaternion.AngleAxis(angelHorizontal, Vector3.up);
        Quaternion rotationY = Quaternion.AngleAxis(angelVertical, Vector3.right);

        transform.rotation = originRotation * rotationX  * rotationY;

      

        /*if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward / stopFactor;
            isWalking = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward / stopFactor;
            isWalking = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right / stopFactor;
            isWalking = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right / stopFactor;
            isWalking = true;
        }*/
    }
}

