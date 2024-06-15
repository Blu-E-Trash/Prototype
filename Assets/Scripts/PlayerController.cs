using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInpiut;
    private float forwardInput;
    void LateUpdate()
    {
        horizontalInpiut = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime*speed*forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInpiut * Time.deltaTime);
    }
}
