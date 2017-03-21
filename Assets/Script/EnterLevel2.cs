using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterLevel2 : MonoBehaviour

{
	public static int score;
	public GameObject Level2button;
	//public Transform currentdoor;


	void OnCollisionEnter()

	{
		Application.LoadLevel("Level2");
		Time.timeScale = 0;
	}


}


