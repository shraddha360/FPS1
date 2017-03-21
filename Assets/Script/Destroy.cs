using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter(Collider collider){

		switch (collider.gameObject.name) {
		case "Sphere":
			Destroy(this.gameObject);

			break;


		}
	}
}
