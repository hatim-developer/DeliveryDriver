using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerAngle = 0.5f;
    [SerializeField] float moveSpeed = 0.01f;
    

    // Update is called once per frame
    void Update()
    {
        float steer = steerAngle * Input.GetAxis("Horizontal");
        float speed = moveSpeed * Input.GetAxis("Vertical");

        transform.Rotate(0, 0, -steer);
        transform.Translate(0, speed, 0);
    }
}
