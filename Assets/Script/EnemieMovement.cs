using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieMovement : MonoBehaviour {
	

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

//	void OnCollisionEnter(Collision col){
//	
//		if (col.gameObject.tag == "wall") {
//			
//
//			zRotation = Input.GetAxis ("Horizontal");
//
//			transform.eulerAngles = new Vector3 (0, 180, zRotation);
//			
//		}

	void OnTriggerEnter(Collider col){

		Debug.Log ("Collid");

			if (col.gameObject.tag == "wall") {


				zRotation = Input.GetAxis ("Horizontal");

				transform.eulerAngles = new Vector3 (0, 180, zRotation);


			}

		   if(col.gameObject.tag=="wall1")
		{


					zRotation = Input.GetAxis("Horizontal");

					transform.eulerAngles = new Vector3(0,0, zRotation);

			}


			
	}

}


	

	

