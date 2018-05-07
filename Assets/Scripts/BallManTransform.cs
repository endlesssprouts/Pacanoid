using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManTransform : MonoBehaviour {

    public GameObject Chomp;
    public SpriteRenderer BallSprite;
    public Rigidbody2D BallChomp;

    public PlayerMode CurrentMode;

	// Use this for initialization
	void Start () {
        CurrentMode = PlayerMode.Ball;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Neon"))
            TranformToChomp();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Neon"))
            TranformToBall();
    }

    private void TranformToChomp()
    {
        Chomp.SetActive(true);
        BallSprite.enabled = false;
        CurrentMode = PlayerMode.ChompMan;
        BallChomp.velocity = Vector3.zero;
    }


    private void TranformToBall()
    {
        Chomp.SetActive(false);
        BallSprite.enabled = true;
        CurrentMode = PlayerMode.Ball;
        Vector3 dropForce = new Vector3(-0.1f, -3f, 0f);
        BallChomp.velocity = dropForce;
    }
}

public enum PlayerMode { Ball, ChompMan };