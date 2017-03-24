using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyM : MonoBehaviour {


	public float zRotation = 5f;
	// Use this for initialization

	void Start () {


	}

	// Update is called once per frame
	public void Update () {

		transform.Translate (0, 0, 10 * Time.deltaTime);


		//		transform.position += transform.forward * Time.deltaTime;

		//		if (distance == 0f) {
		//			transform.Translate;

	}

	void OnTriggerEnter(Collider col){

	

		if (col.gameObject.tag == "wall") {


			zRotation = Input.GetAxis ("Horizontal");

			transform.eulerAngles = new Vector3 (0, 90, zRotation);

		}

		if(col.gameObject.tag=="wall1")
		{


			zRotation = Input.GetAxis("Horizontal");

			transform.eulerAngles = new Vector3(0,270, zRotation);

		}



	}

}