using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour {

    private float paddleSpeed = 0.5f;


    private Vector3 playerPos = new Vector3(-2.26f, -1.75f, 0);

    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        playerPos = new Vector3(Mathf.Clamp(xPos, -3.489f, 0.89f), -1.75f, 0f);
        transform.position = playerPos;

    }
}
