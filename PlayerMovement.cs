using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
	
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
	// Messing with Physics, therefore "fixed".
	void FixedUpdate () {

        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
      
        if ( Input.GetKey("d"))
        {
            //only execute if condition is met
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            //only execute if condition is met
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }

    }
}
