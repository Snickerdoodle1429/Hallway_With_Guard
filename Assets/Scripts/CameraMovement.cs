using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;

    float horizontalInput;
    float veriticalInput;

    float turnSpeed = 300f;

    float xRotate = 0f;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Mouse X") * turnSpeed * 2f * Time.deltaTime;
        veriticalInput = Input.GetAxis("Mouse Y") * turnSpeed * Time.deltaTime;

        xRotate -= veriticalInput;
        xRotate = Mathf.Clamp(xRotate, -45f, 45f);

        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
        player.Rotate(Vector3.up * horizontalInput);

    }
}
