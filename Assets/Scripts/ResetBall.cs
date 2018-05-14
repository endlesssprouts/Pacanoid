using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A script to return the Ball to the Paddle's position

public class ResetBall : MonoBehaviour {

    [SerializeField] private Transform paddle;
    private Vector2 position;
    private float posX;
    private float posY;
    private Ball ballScript;

    void Awake()
    {
        ballScript = this.GetComponent<Ball>();
        if (paddle == null)
        {
            Debug.LogError("Error! Paddle not defined!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("OutOfBounds") )
        {
            ballScript.resetBall();

            //posX = paddle.transform.position.x;
            //posY = paddle.transform.position.y;
            //this.transform.position = new  Vector2(posX , posY + 0.1f);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("OutOfBounds"))
        {
            ballScript.resetBall();
        }
    }
}
