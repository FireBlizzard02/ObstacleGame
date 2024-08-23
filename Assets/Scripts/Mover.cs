using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // [SerializeField] float xValue = 0;
    // [SerializeField] float zValue = 0;
    [SerializeField] float moveSpeed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PlayerInstruction(){
        Debug.Log("Hello Player,Welcome to Obstacle Game.");
        Debug.Log("Use WASD or Arrow Keys to move.");
        Debug.Log("Avoid Obstacle to get maximum points.");
        Debug.Log("Enjoy Playing <3");
    }

    void MovePlayer(){
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
