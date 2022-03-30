using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField]
    private float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
