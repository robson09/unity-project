using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //Control speed of mouse
    public float mouseSensititvity = 100f;

    public Transform playerBody;

    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate independently from current framerate
        float mouseX = Input.GetAxis("Mouse X") * mouseSensititvity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensititvity * Time.deltaTime;

        xRotation -= mouseY;
        //Lock rotation so player won't be able to look on a certain point behind
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
