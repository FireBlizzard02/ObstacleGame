using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidBody;
    [SerializeField] int waitTime = 2;
    [SerializeField] float FallingTime = 2.5f;

    void Start() {
        
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;

        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Time.time>waitTime)
        {
            renderer.enabled = true;
        // {
        //     Debug.Log(waitTime +"seconds has passed.");
        // }        
        }
        if(Time.time>FallingTime)
        {
            rigidBody.useGravity = true;
        }
    }
}
