using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y_Detect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.tag == "Player" & transform.position.y < -75)
        {
            Destroy(gameObject);
        }
            
       
	}
}
