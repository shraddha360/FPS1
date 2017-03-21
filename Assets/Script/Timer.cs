using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	
	public GameObject PauseMenu,GameOver;
	public Text TimerT;
	public bool TimesUp = false;

	public float timeRemaining = 2.0f;

	void Start(){
		GameOver.gameObject.SetActive (false);

	}

	void Update () {
		if (TimesUp == true) {
		}
		timeRemaining -= Time.deltaTime;
		//TimerT = timeRemaining;

		if (timeRemaining < 0 && TimesUp == false) {


			GameOver.gameObject.SetActive (true);

			TimesUp = true;
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			//Time.timeScale = 0;
		}
		if (Input.GetKey ("escape") && TimesUp == true ) 

		{

			//Debug.Log ("level one");
			PauseMenu.gameObject.SetActive (false);

			//				Cursor.lockState = CursorLockMode.None;
			//				Cursor.visible = true;


		}



		}

//		if (Input.GetKey ("escape")) {
//			Cursor.visible = true;
//			Canvas.gameObject.SetActive (false);
	//		}

//
	void OnGUI(){
		if (timeRemaining > 0) {
			GUI.Label (new Rect (100, 100, 200, 100), 
				"Time Remaining : " + timeRemaining);
		} else {
			GUI.Label (new Rect (100, 100, 200, 100), "Time's Up");

//			GameOver.gameObject.SetActive (true);
//
//			Time.timeScale = 0;
//			Cursor.lockState = CursorLockMode.None;
//			Cursor.visible = true;
//


		}
	}
			
		


	  
//		if (Input.GetKey("escape")) {
//			Cursor.visible = true;
//			Canvas.gameObject.SetActive (false);
//		}

}
	