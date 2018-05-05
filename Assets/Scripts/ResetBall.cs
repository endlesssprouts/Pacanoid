using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour {

    [SerializeField] private Transform paddle;
    private Vector2 position;
    private float posX;
    private float posY;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    posX = paddle.transform.position.x;
    posY = paddle.transform.position.y;

        Debug.Log("X is: " + posX + "Y is: " +posY);
    
    }
}
