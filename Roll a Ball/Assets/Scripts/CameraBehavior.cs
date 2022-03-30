using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject ObjectToFollow;
    public Vector3 offset;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = ObjectToFollow.transform.position + offset;
    }
}
