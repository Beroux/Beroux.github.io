using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    [Range(1, 10)]
    public float jumpVelocity;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump2"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
        }
    }
}