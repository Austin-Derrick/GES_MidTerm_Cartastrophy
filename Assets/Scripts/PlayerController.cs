using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 50;
    private float horizontalInput;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(0, 45 * horizontalInput * Time.deltaTime, 0, Space.World);
    }
}
