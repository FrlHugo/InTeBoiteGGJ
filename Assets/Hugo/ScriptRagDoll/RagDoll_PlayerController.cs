using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RagDoll_PlayerController : MonoBehaviour
{
    public float speed;
    public float strafeSpeed;
    public float jumpForce;

    public Rigidbody hips;

    public bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        hips = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Z))
        {
            if(Input.GetKey(KeyCode.LeftShift))
            {
                hips.AddForce(hips.transform.forward * speed * 1.5f);

            }
            else
            {
                hips.AddForce(hips.transform.forward * speed);
            }
           
        }

        if (Input.GetKey(KeyCode.Q))
        {
            hips.AddForce(-hips.transform.right * strafeSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            hips.AddForce(-hips.transform.forward * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            hips.AddForce(hips.transform.right * strafeSpeed);
        }

    }
}
