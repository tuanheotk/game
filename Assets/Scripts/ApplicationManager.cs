using UnityEngine;
using System.Collections;

public class ApplicationManager : MonoBehaviour {
	

	public void Play () 
	{
		Application.LoadLevel ("RocketMouse");
	}
	public void ReturnToMain () 
	{
		Application.LoadLevel ("Menu 3D");
	}
	public void Quit () 
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
