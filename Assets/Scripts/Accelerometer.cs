using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour {
    public bool isFlat = true;
    private Rigidbody rigid;


    // Use this for initialization
    void Start () {
        //Screen.orientation = ScreenOrientation.LandscapeLeft;
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 tilt = Input.acceleration;

        if(isFlat)
        {
            tilt = Quaternion.Euler(90, 0, 0) * tilt;
        }
        rigid.AddForce(tilt);
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.cyan);
	}
}


// https://www.youtube.com/watch?v=8ugE1HQPA9g
// https://www.youtube.com/watch?v=bJE7vFwpELw