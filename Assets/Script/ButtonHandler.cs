using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour {

	public GameObject Canvas;
	public bool Paused ;
	public GameObject Camera;




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
				
			Debug.Log ("Escape");
			Canvas.gameObject.SetActive (true);
			Cursor.visible = true;
			//Application.Quit ();
			Time.timeScale = 0;

		
			//Screen.lockCursor = true;
					
			//	Paused = false;
//				} else {
//					Time.timeScale = 0.0f;
//					Canvas.gameObject.SetActive (true);
//				Cursor.visible  = true;
//					Screen.lockCursor = false;
//
//					Paused = true;
//				}
		}
	}

		public void Resume()
	{
		
		Time.timeScale = 1;
		Debug.Log ("Resume");
		Paused = false;
		Canvas.gameObject.SetActive (false);
		Cursor.visible  = false;
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
		Cursor.visible  = true;


	}


//	void Resume(){
//		
//		isPaused = false;
//		pauseMenu.SetActive(false);
//		Time.timeScale = 1;
//	}
	


}


	
