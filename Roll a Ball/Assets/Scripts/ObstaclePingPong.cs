using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePingPong : MonoBehaviour
{
    [SerializeField]
    private float distanceToCover;
    [SerializeField]
    private float speed;
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong( ( speed * Time.time ), distanceToCover ));
    }
}
