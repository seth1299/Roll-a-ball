using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePingPong : MonoBehaviour
{
    [SerializeField]
    public float distanceToCover;
    [SerializeField]
    public float speed;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = startPosition;
        v.z = distanceToCover * Mathf.Sin(Time.time * speed);
        transform.position = v; 
    }
}
