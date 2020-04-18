using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroTest : MonoBehaviour {
    private RemoteGyroscope gyroscope;
	// Use this for initialization
	void Start () {
        gyroscope = GyroMote.gyro();
        //gyroscope.attitude;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
