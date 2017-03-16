using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	public float timeLeft = 0;

	public RaycastHit hit;

	public Transform currentdoor;
	public bool open = false;

	public bool IsOpeningDoor;

	public Transform cam;

	public LayerMask mask;

	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.O) && timeLeft == 0.0f) {
			//CheckDoor ();
			Debug.Log("KeyPressed");
			OpenAndCloseDoor ();
		}

		if (open == true) {
			//timeLeft += Time.deltaTime;
		}

		
	}

//	public void CheckDoor(){
//
//		if (Physics.Raycast (cam.position, cam.forward, out hit, 10, mask)) {
//		
//			open = false;
//			if (hit.transform.localRotation.eulerAngles.y > 45)
//				open = true;
//			
//			IsOpeningDoor = true;
//			currentdoor = hit.transform;
//		}
	
	
//}

//	void OnCollisionEnter(Collision collision){
//
//
//		if (collision.gameObject.tag == "Player") {
//			OpenAndCloseDoor ();
//			open = true;
//			Destroy (this.gameObject);
//
//
//
//		}
//	}

	void OnTriggerEnter()
	{
		open = true;
		OpenAndCloseDoor ();


	 }

	void OnTriggerExit(Collider collision)
	{
		if (collision.gameObject.tag == "player") {
			Debug.Log ("Close");
			open = false;
			OpenAndCloseDoor ();
	

		}
	}

	public void OpenAndCloseDoor()
	{
		
		//timeLeft += Time.deltaTime;

		if (open) {
			Debug.Log ("Open");
			currentdoor.localRotation = Quaternion.Slerp (currentdoor.localRotation, Quaternion.Euler (0, 90, 0), timeLeft);
		
		}
		if (open == false) { 
			Debug.Log ("close");

			//yield return WaitForSeconds (5f);
			currentdoor.localRotation = Quaternion.Slerp (currentdoor.localRotation, Quaternion.Euler (0, 0, 0), timeLeft);
//			if (timeLeft > 1) {
//		
//				timeLeft = 0;
//				IsOpeningDoor = false;
//
//			}
		}
		}
	}


