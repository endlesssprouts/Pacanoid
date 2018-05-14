using System.Collections;
using System.Collections.Generic;

using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class LevelManagerBehaviour : MonoBehaviour
{
	public void LoadNextLevel()
	{
		LevelManager.LoadNextLevel();
	}

	public void LoadPreviousLevel()
	{
		LevelManager.LoadPreviousLevel();
	}

#if UNITY_EDITOR
	//protected override void OnDrawGizmos()
	//{

	//}
#endif
}