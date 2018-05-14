using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
	[SerializeField] private int _hitPoints = 3;

	[Range(0.1f, 2f)]
	[SerializeField] private float _destroyDelay = 0.1f;

	[SerializeField] private LayerMask _hitLayerMask;

	private void Start()
	{
		GameController.ObjectivesCount++;
	}

	public void TakeDamage()
	{
		this._hitPoints--;

		if (this._hitPoints <= 0)
		{
			Destroy(this.gameObject, this._destroyDelay);

			GameController.ObjectivesCount--;
		}
	}

	private void OnCollisionEnter2D(Collision2D coll)
	{
		if ((this._hitLayerMask & (1 << coll.gameObject.layer)) > 0)
		{
			this.TakeDamage();
		}

		if (GameController.ObjectivesCount <= 0)
		{
			LevelManager.LoadNextLevel();
		}
	}
}
