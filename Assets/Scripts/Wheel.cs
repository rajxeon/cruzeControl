﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour {


    public int speed = 100;
	// Use this for initialization
	void Start () {

    
	}
	
	// Update is called once per frame
	void FixedUpdate() {
        transform.Rotate(Vector3.up * Time.deltaTime* speed);

    }
}
