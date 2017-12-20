using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Win : MonoBehaviour {
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
