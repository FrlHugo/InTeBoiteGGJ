using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float rotationSpeed;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movDir = new Vector3(horizontalInput, 0, verticalInput).normalized;

        if (movDir != Vector3.zero)
        {
            //Quaternion toRotation = Quaternion.LookRotation(new Vector3(horizontalInput, 0, verticalInput), Vector3.up);
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            transform.LookAt(transform.position + movDir, Vector3.up);
        }
    }
}
