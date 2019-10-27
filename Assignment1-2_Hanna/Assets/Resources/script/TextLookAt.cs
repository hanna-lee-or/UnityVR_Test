﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLookAt : MonoBehaviour
{
    public Transform cam;

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - cam.position);
    }
}
