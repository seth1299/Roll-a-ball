using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private float movementSpeed;
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(0f, 0f, movementSpeed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(0f, 0f, -movementSpeed);
        }
    }
}