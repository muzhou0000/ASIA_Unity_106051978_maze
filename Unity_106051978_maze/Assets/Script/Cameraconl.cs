using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraconl : MonoBehaviour
{
    [Header("旋轉"), Range(10, 200)]
    public float turn;

    public Transform cam, mouse;

    private void Start()
    {
       
    }
    void Update()
    {
        Vector3 pos = Vector3.Lerp(cam.position, mouse.position, 0.5f * Time.deltaTime);
        cam.position = pos;
        Turn();
    }

    void Turn()
    {
        float camera_h = Input.GetAxis("Horizontal");
        cam.Rotate(0, turn * camera_h * Time.deltaTime, 0);

    }
}