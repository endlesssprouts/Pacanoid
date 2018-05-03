using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
	[SerializeField] private float _paddleMovementSpeed = 5f;

	[SerializeField] private float _minXPosition = -3.489f;
	[SerializeField] private float _maxXPosition = 0.89f;

	private void Update()
	{
		float movementDistance = Input.GetAxisRaw("Horizontal") * this._paddleMovementSpeed * Time.deltaTime;

		this.transform.position = new Vector3(Mathf.Clamp(this.transform.position.x + movementDistance, this._minXPosition, this._maxXPosition), this.transform.position.y, this.transform.position.z);
	}

#if UNITY_EDITOR
	[Header("Editor Only")]
	[SerializeField] private float _indicatorHeight = 0.85f;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;

		Gizmos.DrawCube(
			new Vector3(this._minXPosition, this.transform.position.y, this.transform.position.z),
			new Vector3(0.05f, this._indicatorHeight, 1f)
		);

		Gizmos.DrawCube(
			new Vector3(this._maxXPosition, this.transform.position.y, this.transform.position.z),
			new Vector3(0.05f, this._indicatorHeight, 1f)
		);

		Gizmos.DrawLine(
			new Vector3(this._minXPosition, this.transform.position.y - this._indicatorHeight / 2f, this.transform.position.z), 
			new Vector3(this._minXPosition, this.transform.position.y + this._indicatorHeight / 2f, this.transform.position.z)
		);

		Gizmos.DrawLine(
			new Vector3(this._maxXPosition, this.transform.position.y - this._indicatorHeight / 2f, this.transform.position.z), 
			new Vector3(this._maxXPosition, this.transform.position.y + this._indicatorHeight / 2f, this.transform.position.z)
		);
	}
#endif
}
