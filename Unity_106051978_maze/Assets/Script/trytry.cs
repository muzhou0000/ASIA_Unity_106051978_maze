using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trytry : MonoBehaviour
{


    [Header("旋轉"), Range(10, 200)]
    public float turn;

    public Transform cam, mouse, cam2;
    public float speed = 3;


    void Update()
    {
        Vector3 pos = Vector3.Lerp(cam.position, mouse.position, 0.5f * Time.deltaTime * speed);
        cam.position = pos;
        Turn();
        Vector3 pos_2 = Vector3.Lerp(cam2.position, mouse.position, 0.3f * Time.deltaTime * speed);
        cam2.position = pos_2;

    }
    void Turn()
    {
        float camera_h = Input.GetAxis("Horizontal");
        cam.Rotate(0, turn * camera_h * Time.deltaTime, 0);

    }
}