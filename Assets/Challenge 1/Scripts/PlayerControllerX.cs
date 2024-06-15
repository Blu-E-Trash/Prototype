using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    private float verticalInput;
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed*Time.deltaTime);

        transform.Rotate(new Vector3(verticalInput * rotationSpeed * Time.deltaTime, 0,0));
    }
}
