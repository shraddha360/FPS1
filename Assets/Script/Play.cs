using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {
	

	// Use this for initialization
	public void Start ()

	{
		Screen.lockCursor = false;
		Cursor.visible  = true;
//		Application.LoadLevel("C#1");
//		Time.timeScale = 0;
		
	}
	
	public void NextLevelButton()
	{
		Application.LoadLevel("Level1");
	}

	public void Quit()
	{
		Debug.Log ("Quit");
		Application.Quit ();
	}

}
