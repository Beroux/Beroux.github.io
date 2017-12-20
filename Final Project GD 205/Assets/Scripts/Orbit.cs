using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {
    public GameObject center;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        {
            transform.RotateAround(Vector3.zero, Vector3.up, 15 * Time.deltaTime); 
            //this script does what it says on the package, set a center and whatever it's applied to will orbit it
        }
    }
}
