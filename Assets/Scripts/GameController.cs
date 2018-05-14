using System.Collections;
using System.Collections.Generic;

using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameController : MonoBehaviour
{
	public static int ObjectivesCount;

#if UNITY_EDITOR
	//protected override void OnDrawGizmos()
	//{

	//}
#endif
}

#if UNITY_EDITOR
[CustomEditor(typeof(GameController))]
[CanEditMultipleObjects]
public class GameControllerEditor : Editor
{
	private void OnEnable()
	{

	}

	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

#pragma warning disable 0219
		GameController sGameController = target as GameController;
#pragma warning restore 0219
	}
}
#endif