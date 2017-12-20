using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour {
    public float speed = 2f;
    public float delay = 0f;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    [Range(1, 10)]
    public float jumpVelocity;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump2") && Time.time > delay)
        {
            delay = Time.time + speed;
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
        }
    }
}
//script for Player2's jump