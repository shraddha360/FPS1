using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpidyPan : MonoBehaviour {
	public static int score;  
	public string L5;
	Text text;  

	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);

		text = GetComponent <Text> ();
		L5 = "Level5";
	}
	
	// Update is called once per frame
	void Update () {
		if (score == 10 && Application.loadedLevelName == L5) {
			gameObject.SetActive (true);
//			Invoke ("wait", 2);

		}
	}

//		void Wait()
//		{
//			Kill.gameObject.SetActive(false);
//
//		}
}
