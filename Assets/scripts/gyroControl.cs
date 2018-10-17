﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroControl : MonoBehaviour {

    private bool isFlat = true;
    private Rigidbody rb;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
       Vector3 tilt = Input.acceleration;
        if (isFlat)
        tilt = Quaternion.Euler(90, 0, 0) * tilt;
       // transform.Translate(0.09f*Input.acceleration.x, 0.09f * Input.acceleration.z, 0);
        rb.AddForce(tilt*30);
	}
}
