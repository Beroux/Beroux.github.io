using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour {
    public Transform target;
    Rigidbody seeker;
    public float thrust;
    public int secs2wait = 5;
    public int[] totalSec = new int[5];


           
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("TimerInvoke", 1, 1);
        seeker = GetComponent<Rigidbody>();
    }

    void TimerInvoke()
    {
       // if (totalSec[0] < secs2wait)
         //   totalSec[0]++;
       // else
         //   CancelInvoke("TimerInvoke");
        Vector3 targetDir = Vector3.Normalize(target.position - transform.position);
        seeker.AddForce(targetDir * thrust);
    }


// Update is called once per frame
void Update () {
        

    }
}
