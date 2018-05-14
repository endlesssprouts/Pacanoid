using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManTransform : MonoBehaviour
{
	public enum PlayerMode { Ball, ChompMan }

	public GameObject Chomp;
	public SpriteRenderer BallSprite;
	public Rigidbody2D BallChomp;

	private PlayerMode _currentMode = PlayerMode.Ball;
	public PlayerMode _CurrentMode { get { return this._currentMode; } }

	[SerializeField] private LayerMask _transformationLayerMask;

	private void OnTriggerEnter2D(Collider2D other)
	{
        if ((this._transformationLayerMask & (1 << other.gameObject.layer)) > 0)
            this.TranformToChomp();
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if ((this._transformationLayerMask & (1 << other.gameObject.layer)) > 0)
            Invoke("TranformToBall", 0.1f);
	}

	private void TranformToChomp()
	{
		Chomp.SetActive(true);
		BallSprite.enabled = false;
		_currentMode = PlayerMode.ChompMan;
        BallChomp.velocity = Vector3.zero;

    }


	private void TranformToBall()
	{
		Chomp.SetActive(false);
		BallSprite.enabled = true;
		_currentMode = PlayerMode.Ball;
		Vector3 dropForce = new Vector3(-0.1f, -3f, 0f);
        BallChomp.velocity = dropForce;
	}

}