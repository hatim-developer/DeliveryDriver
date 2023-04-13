using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerAngle = 300f;
    [SerializeField] float moveSpeed = 10f;
    

    // Update is called once per frame
    void Update()
    {
        float steer = steerAngle * Input.GetAxis("Horizontal") * Time.deltaTime;
        float speed = moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Rotate(0, 0, -steer);
        transform.Translate(0, speed, 0);
    }
}
