using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClose : MonoBehaviour {

	public Transform currentdoor;





	void OnTriggerEnter()
	{
		
		currentdoor.localRotation = Quaternion.Slerp (currentdoor.localRotation, Quaternion.Euler (0, 0, 0), 3f);



	}


}
