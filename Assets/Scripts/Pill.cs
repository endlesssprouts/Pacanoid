using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pill : MonoBehaviour
{
	private void Start()
	{
		GameController.ObjectivesCount++;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			Destroy(gameObject);

			GameController.ObjectivesCount--;
		}

		if (GameController.ObjectivesCount <= 0)
		{
			LevelManager.LoadNextLevel();
		}
	}
}
