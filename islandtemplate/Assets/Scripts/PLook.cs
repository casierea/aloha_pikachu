using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLook : MonoBehaviour
{
    public float mouseSensitive = 100f;
    public Transform characterBody;
    private float xRotate = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

  
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitive * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitive * Time.deltaTime;

        xRotate -= mouseY;
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
        characterBody.Rotate(Vector3.up * mouseX);
       
    }
}