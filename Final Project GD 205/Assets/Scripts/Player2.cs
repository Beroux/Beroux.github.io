using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

    Rigidbody rb;
    public float thrustAmt;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void FixedUpdate () {
        if (Input.GetKey (KeyCode.I)) {
            rb.AddForce (Vector3.forward * thrustAmt);
        }
        if (Input.GetKey (KeyCode.K)) {
            rb.AddForce (Vector3.back * thrustAmt);
        }
        if (Input.GetKey (KeyCode.J)) {
            rb.AddForce (Vector3.left * thrustAmt);
        }
        if (Input.GetKey (KeyCode.L)) {
            rb.AddForce (Vector3.right * thrustAmt);
        }
    }
}
