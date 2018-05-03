using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManTransform : MonoBehaviour {

    public GameObject Chomp;
    public SpriteRenderer BallSprite;

	// Use this for initialization
	void Start () {
		
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
    }


    private void TranformToBall()
    {
        Chomp.SetActive(false);
        BallSprite.enabled = true;
    }
}
