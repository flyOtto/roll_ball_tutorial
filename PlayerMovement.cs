using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
	
	// Messing with Physics
	void FixedUpdate () {

        rb.AddForce(0, 0, 2000 * Time.deltaTime);
		
	}
}
