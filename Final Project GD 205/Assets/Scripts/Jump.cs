using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    public float speed = 2f;
    public float delay = 0f;

	// Use this for initialization
	void Start () {
		
	}
    [Range(1, 10)]
    public float jumpVelocity;
    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Jump")&& Time.time > delay)
        {
            delay = Time.time + speed;
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;

        }
	}
}
