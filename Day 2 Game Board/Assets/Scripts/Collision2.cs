using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision2 : MonoBehaviour
{
    public GameObject White;
    public Vector3 initialPosition;
   

    // Use this for initialization
    void Start()
    {
        Vector3 initialPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {



    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "White")
        {
            White.transform.position = initialPosition;
        }

    }
}
