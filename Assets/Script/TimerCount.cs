using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerCount : MonoBehaviour {
	

	public GameObject PauseMenu,GameOver;
	public float timeRemaining;
	public bool TimesUp = false;
	public Text text;

	// Use this for initialization
	void Start () {


		text = GetComponent <Text> ();




		timeRemaining = 50;

		GameOver.gameObject.SetActive (false);


		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (TimesUp == true) {
		}
			
		text.text = "Time: " + timeRemaining;
		//Time.timeScale = 0;



			if (timeRemaining > 0.0f ) {
			timeRemaining -= Time.deltaTime;
			text.text = "Time: " + timeRemaining;

			}

		if (timeRemaining < 0.0f&& TimesUp==false) {
			Time.timeScale = 0;
			GameOver.gameObject.SetActive (true);
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			timeRemaining = 0;
			TimesUp = true;
		}

		if (Input.GetKey ("escape")&& TimesUp == true )

			{
			PauseMenu.gameObject.SetActive(false);

			}




		}
		}


	

