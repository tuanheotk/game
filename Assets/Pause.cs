using UnityEngine;
using System.Collections;
using UnityEngine;
public class Pause : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	void Update () {
		if( Input.GetKeyDown (KeyCode.Escape)){
			if (GameIsPaused)
				Resume ();
			else
				Pauses ();
		}
	}
	void Resume(){
		pauseMenuUI.SetActive(true);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}
	void Pauses(){
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

}
