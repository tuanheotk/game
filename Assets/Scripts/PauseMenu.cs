using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {

	public string mainMenuScene; 
	public GameObject pauseMenu;
	public bool isPaused;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			if (isPaused) {
				ResumeGame ();
			} else {
				isPaused = true;
				pauseMenu.SetActive (true);
				Time.timeScale = 0f;
			}

		}
	}
	public void ResumeGame(){
		isPaused = false;
		pauseMenu.SetActive (false);
		Time.timeScale = 1f;
	}

	public void ReturnToMain(){
		SceneManager.LoadScene (mainMenuScene);
	}
}
