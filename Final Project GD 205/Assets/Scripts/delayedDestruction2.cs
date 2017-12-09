using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delayedDestruction2 : MonoBehaviour {
    public float timer;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += 1.0F * Time.deltaTime;
        if (timer >= 15)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
