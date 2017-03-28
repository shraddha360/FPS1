using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour {

	public GameObject mainMenu;
	public GameObject ControlPanel;
	public GameObject pauseMenu;
	public bool Paused ;
	public GameObject ContronButton;

//	public GameObject Control;
	public string L1, L2, L3, L4,L5,L0;

	//public GameObject Camera;




//	public GameObject Resume, Quit;



	void Start(){

		L1 = "Level1";
		L2 = "Level2";
		L3 = "Level3";
		L4 = "Level4";
		L5 = "Level5";
		L0 = "Level0";

		if (Application.loadedLevelName == L0) 
		{
			ControlPanel.gameObject.SetActive (false);
		}

		ContronButton = GameObject.Find ("Control");
	}

	void Update ()
	{

		if (Application.loadedLevelName == L0) {
			
			//mainMenu.gameObject.SetActive (true);




			//Con.SetActive (true);

//			Panel = GameObject.Find ("Controlpanel");

	

//		    Controller();
		
		}



		if (Input.GetKey ("escape")) {
				
			pauseMenu.gameObject.SetActive (true);
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			Time.timeScale = 0;

		}
	}


		public void Resume()
	{
		
		Time.timeScale = 1;
		Debug.Log ("Resume");
		Paused = false;
		pauseMenu.gameObject.SetActive (false);
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
		Application.LoadLevel("Level0");
		Time.timeScale = 1;
		Screen.lockCursor = false;
		//Cursor.visible  = true;


	}

	public void RestartL2()

	{

		Application.LoadLevel(Application.loadedLevel);
		Time.timeScale = 1;

	}


	public void back()
	{

		if (Application.loadedLevelName == L0) {

			ControlPanel.gameObject.SetActive (false);
			mainMenu.gameObject.SetActive (true);
			//Time.timeScale = 1;
		
			Application.LoadLevel ("Level0");
			Time.timeScale = 1;
			Screen.lockCursor = false;
			//Cursor.visible  = true;
		}
	}

		public void Controller ()
		{
		
		if (Application.loadedLevelName == L0) {
			Debug.Log ("Con");

			ControlPanel.SetActive (true);
			mainMenu.SetActive (false);
			Time.timeScale = 1;

		}


	}

}










	
