using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public static class LevelManager
{
	public static void LoadNextLevel()
	{
		if (SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCount)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}

	public static void LoadPreviousLevel()
	{
		if (SceneManager.GetActiveScene().buildIndex - 1 >= 0)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
		}
	}

#if UNITY_EDITOR
	//protected override void OnDrawGizmos()
	//{

	//}
#endif
}