﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Player1Win : MonoBehaviour {
    public string LeveltoLoad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.tag == "Player" & transform.position.y < -75)
        {
            SceneManager.LoadScene(LeveltoLoad);
        }
    }
}
