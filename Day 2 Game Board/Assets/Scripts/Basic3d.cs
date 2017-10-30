using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic3d : MonoBehaviour
{

    public GameObject mover;
    public Vector3 movementAmount;
    public Vector3 negative;
    public Vector3 updown;
    public Vector3 downup;

    // Use this for initialization
    void Start()
    {
        movementAmount = new Vector3(1, 0, 0);
        negative = new Vector3(-1, 0, 0);
        updown = new Vector3(0,0,1);
        downup = new Vector3(0,0,-1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            mover.transform.position += movementAmount;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            mover.transform.position += negative;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            mover.transform.position += updown;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            mover.transform.position += downup;
        }

        else
        {
            
        }

    }


}