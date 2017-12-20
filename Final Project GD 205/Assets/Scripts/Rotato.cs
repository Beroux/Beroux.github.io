using UnityEngine;
using System.Collections;

public class Rotato : MonoBehaviour
{
    public float speed = 10f;


    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
        //rotation script, apply to spin. Speed can be edited within unitys
    }
}