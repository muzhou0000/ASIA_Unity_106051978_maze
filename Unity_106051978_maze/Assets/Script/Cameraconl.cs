using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraconl : MonoBehaviour
{

    public Transform cam, mouse;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.Lerp(cam.position, mouse.position, 0.5f * Time.deltaTime);
        cam.position = pos;
    }
}