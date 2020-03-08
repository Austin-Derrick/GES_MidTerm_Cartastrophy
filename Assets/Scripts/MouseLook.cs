using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    private float mouseSensitivityX = 1.5f;
    private float mouseSensitivityY = 1.5f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        float deltaMouseX = Input.GetAxis("Mouse X") * mouseSensitivityX;
        float deltaMousey = Input.GetAxis("Mouse Y") * mouseSensitivityY;

        float rotationY = transform.eulerAngles.y + deltaMouseX;
        float rotationX = transform.eulerAngles.x - deltaMousey;

        transform.eulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
