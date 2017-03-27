using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour {



	// Use this for initialization
	void Start () {
		gameObject.SetActive (true);

		Invoke ("info", 3f);
	}
	
	// Update is called once per frame
	void info(){

		gameObject.SetActive (false);
	}
}
