﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CarControl : MonoBehaviour {
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float translation = CrossPlatformInputManager.GetAxis("Vertical") * speed;
        float rotation = CrossPlatformInputManager.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

    }
}


//https://www.youtube.com/watch?v=O7Gd58wMZns