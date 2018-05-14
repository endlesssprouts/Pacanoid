using System.Collections;
using System.Collections.Generic;

using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class Ghost : MonoBehaviour
{
	[Header("AI")]

	[SerializeField] private Transform[] _waypoints;

	[Header("Ghost")]

	[SerializeField] private float _movementSpeed = 1f;

	private int _targetWaypointIndexRaw;

	private int GetDir(int index, int length)
	{
		// Debug.Log("Pam pam: " + (index % length) + (((index / length + 1) % 2) * 2 - 1));
		return (((index / length + 1) % 2) * 2 - 1);
	}

	private int PingPongCorrect(int index, int length)
	{
		int value = index % ((length - 1) * 2);

		if (value < length)
			return value;

		return ((length - 1) * 2) - value;
	}

	private int PingPong(int index, int length)
	{
		return (length + length * ((index / length) % 2)) - index % (length * 2);
	}

	private void Update()
	{
		// Debug.Log("Dir: " + this.GetDir(this._targetWaypointIndexRaw, this._waypoints.Length));

		// Debug.Log("" + this.PingPongCorrect(this._targetWaypointIndexRaw, this._waypoints.Length));

		int targetWaypointIndex = this.PingPongCorrect(this._targetWaypointIndexRaw, this._waypoints.Length);

		if ((this._waypoints[targetWaypointIndex].position - this.transform.position).sqrMagnitude < 0.001f)
			targetWaypointIndex = this.PingPongCorrect(++this._targetWaypointIndexRaw, this._waypoints.Length);

		this.transform.position = Vector3.MoveTowards(this.transform.position, this._waypoints[targetWaypointIndex].position, this._movementSpeed * Time.deltaTime);
	}

#if UNITY_EDITOR
	protected virtual void OnDrawGizmos()
	{

	}
#endif
}