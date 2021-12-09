﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject SpikeBall;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - SpikeBall.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = SpikeBall.transform.position + offset;
    }

}
