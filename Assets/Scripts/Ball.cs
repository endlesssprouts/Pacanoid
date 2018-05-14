using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	[SerializeField] private Vector3 _initialForce = new Vector3(0f, 1f, 0f);
	[SerializeField] private Vector3 _initialPosition = new Vector3(0f, 0f, 0f);

	private Rigidbody2D _rigidbody2D;

	private void Awake()
	{
		this._rigidbody2D = this.GetComponent<Rigidbody2D>();
	}

	private void Start()
	{
		this._rigidbody2D.velocity = this._initialForce;
	}

	public void ResetBall()
	{
		this._rigidbody2D.velocity = this._initialForce;
	}

	[SerializeField] private LayerMask _hitLayerMask;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if ((this._hitLayerMask & (1 << collision.gameObject.layer)) > 0)
		{
			this._rigidbody2D.velocity = Quaternion.Euler(new Vector3(0f, 0f, Random.Range(-30, 30))) * this._rigidbody2D.velocity;
		}
	}
}
