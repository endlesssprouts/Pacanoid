using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A script to return the Ball to the Paddle's position

public class ResetBall : MonoBehaviour {

    [SerializeField] private Transform paddle;
    private Vector2 position;
    private float posX;
    private float posY;

    void Awake()
    {
        if (paddle == null)
        {
            Debug.LogError("Error! Paddle not defined!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("OutOfBounds") )
        {
            posX = paddle.transform.position.x;
            posY = paddle.transform.position.y;
            this.transform.position = new  Vector2(posX , posY + 0.1f);
        }
    }
}
