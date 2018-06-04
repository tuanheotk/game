using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneClick : MonoBehaviour {
	public void LoadScene(int sceneMouse){
		SceneManager.LoadScene (sceneMouse);
	}

}
