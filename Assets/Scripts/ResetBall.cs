using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// A script to return the Ball to the Paddle's position

public class ResetBall : MonoBehaviour
{
	[SerializeField] private Transform _resetPoint;
	private Vector2 position;
	private float posX;
	private float posY;
	private Ball ballScript;

	void Awake()
	{
		ballScript = this.GetComponent<Ball>();
	}

	private void Die()
	{
		ballScript.ResetBall();
		this.transform.position = this._resetPoint.position;

		PacanoidSceneManager.Lives--;

		if (PacanoidSceneManager.Lives <= 0)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

			PacanoidSceneManager.Lives = 300;
		}
	}

	private void Update()
	{
		if (this.transform.position.y < -5f)
		{
			this.Die();
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("OutOfBounds"))
		{
			this.Die();
		}
	}
}
