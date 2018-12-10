using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    //links to our player to get information for the camera to follow
    public Transform player;
    public Vector3 offset;
	// Update is called once per frame
	void Update () {

        transform.position = player.position + offset;
	}
}
