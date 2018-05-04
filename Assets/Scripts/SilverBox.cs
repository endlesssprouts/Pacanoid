using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverBox : MonoBehaviour
{

    private int SilverBoxRemainingHitpoints;
    private float DistroyDelay = 0.1f;

    // Use this for initialization
    void Start()
    {
        SilverBoxRemainingHitpoints = 3;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            this.takeAHit();
            Debug.Log("BoxHit");
        }

    }

    private void takeAHit()
    {
        SilverBoxRemainingHitpoints--;

        if (SilverBoxRemainingHitpoints <= 0)
        {
            Invoke("DistroyMe", DistroyDelay);
        }
    }

    private void DistroyMe()
    {
        Destroy(gameObject);
    }
}
