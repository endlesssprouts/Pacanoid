using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	[SerializeField] private Vector3 _initialForce = new Vector3(0f, 1f, 0f);

	private Rigidbody2D _rigidbody2D;

	private void Update()
	{
		Debug.Log(this._rigidbody2D.velocity);
	}

	private void Awake()
	{
		this._rigidbody2D = this.GetComponent<Rigidbody2D>();
	}

	private void Start()
	{
		this._rigidbody2D.velocity = this._initialForce;
	}
}
