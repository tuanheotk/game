﻿using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	public void Quite () 
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
