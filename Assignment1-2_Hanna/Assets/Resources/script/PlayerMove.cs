using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int playerSpeed = 4;
    public Transform cam;
    public float boundary = 225;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Vector3 pos = transform.position;
            pos += cam.forward * playerSpeed * Time.deltaTime;
            // x 경계값 설정
            if (pos.x >= boundary) pos.x = boundary;
            else if (pos.x <= -boundary) pos.x = -boundary;
            // z 경계값 설정
            if (pos.z >= boundary) pos.z = boundary;
            else if (pos.z <= -boundary) pos.z = -boundary;
            // 앞으로 이동
            transform.position = pos;
        }

    }
}
