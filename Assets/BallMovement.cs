using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    GameObject paddle;
    Vector2 paddleToBallOffset;
    bool hasclicked = false;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallOffset =   transform.position-paddle.transform.position ;//diffence between paddle pos-bALLpos
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasclicked)
        {
            LockTheBallToPAddle();
            LaunchTheBall();
        }
       
    }

    private void LaunchTheBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasclicked = true;
            GetComponent<Rigidbody2D>().velocity = Vector2.up*speed;
        }
    }

    private void LockTheBallToPAddle()
    {
        Vector2 paddlePosition = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePosition + paddleToBallOffset;
    }
}
