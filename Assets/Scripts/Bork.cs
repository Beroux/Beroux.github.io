using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bork : MonoBehaviour {
    public Collider Player;
    public Collider bork;
    public AudioClip bjork;
    public AudioSource nyan;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            nyan.PlayOneShot(bjork, 0.5f);

        }
    }
}
