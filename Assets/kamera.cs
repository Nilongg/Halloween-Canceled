using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public float sensitivity;
    public Transform orientation;

    float xRotation;
    float yRotation;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X");
        float mouseY = Input.GetAxisRaw("Mouse Y");

        xRotation -= mouseY * sensitivity * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        orientation.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.Rotate(Vector3.up, mouseX * sensitivity * Time.deltaTime);
        

        
    }
}
