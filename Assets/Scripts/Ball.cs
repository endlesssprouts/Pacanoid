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
        this._initialPosition = transform.position;
	}

    public void resetBall(){
        this._rigidbody2D.velocity = this._initialForce;
        this._rigidbody2D.position = this._initialPosition;
    }
}
