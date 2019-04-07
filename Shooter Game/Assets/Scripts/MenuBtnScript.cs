using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBtnScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadMainScene(){
		SceneManager.LoadScene ("MainScene");	
	}

	public void GoBack(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void LoadHelp(){
		SceneManager.LoadScene ("Help");
	}
	public void QuitGame(){
		Application.Quit ();
	}
}
