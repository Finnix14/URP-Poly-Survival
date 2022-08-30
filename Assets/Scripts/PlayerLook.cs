using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{


    [Header("References")]
 

    [SerializeField] public float sensX = 100f, sensY = 100f;

    [SerializeField] Transform cam = null;
    [SerializeField] public Transform orientation = null;

    [SerializeField] Camera fpscam;
    public PlayerLook look;

    float mouseX, mouseY;

    float multiplier = 0.01f;

    float xRotation, yRotation;

    private void Start()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        fpscam = Camera.main;
        transform.rotation = Quaternion.Euler(mouseX, mouseY, transform.rotation.eulerAngles.z);
    }

    private void Update()
    {
        if(Time.timeScale == 1)
        {
            mouseX = Input.GetAxisRaw("Mouse X");
            mouseY = Input.GetAxisRaw("Mouse Y");

            yRotation += mouseX * sensX * multiplier;
            xRotation -= mouseY * sensY * multiplier;

            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            cam.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
            orientation.transform.rotation = Quaternion.Euler(0, yRotation, 0);
        }
    }
}