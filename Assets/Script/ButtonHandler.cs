using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour {

	public GameObject Canvas;
	public bool Paused ;

	//public GameObject Camera;




//	public GameObject Resume, Quit;



	void Start(){
	
//		Paused = false;
		Canvas.gameObject.SetActive (false);
	
	}

	void Update(){
	
//		if(Input.GetKeyDown (KeyCode.Escape)) 
//
//			Time.timeScale = 0;
		if (Input.GetKey ("escape")) {
				
	     	//Debug.Log ("level one");
			Canvas.gameObject.SetActive (true);

			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			//Application.Quit ();
			Time.timeScale = 0;

		}
	}

		public void Resume()
	{
		
		Time.timeScale = 1;
		Debug.Log ("Resume");
		Paused = false;
		Canvas.gameObject.SetActive (false);
		//Cursor.visible  = false;
		//Screen.lockCursor = true;

		}

	public void Exit()

	{

		Application.Quit ();
	
	}

	public void Menu()
	{
		//Time.timeScale = 1;
		Debug.Log("Menu");
		Application.LoadLevel("Main Menu");
		Time.timeScale = 1;
		Screen.lockCursor = false;
		//Cursor.visible  = true;


	}

	public void RestartL2()

	{

		Application.LoadLevel ("Level2");
		Time.timeScale = 1;

	}


//	void Resume(){
//		
//		isPaused = false;
//		pauseMenu.SetActive(false);
//		Time.timeScale = 1;
//	}
	


}


	
