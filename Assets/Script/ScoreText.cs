using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreText : MonoBehaviour
{
	public static int score;        
//	public Transform currentdoor;
	Text text;   
	public string L1,L2,L3,L4;

	void Start ()
	{
		L1 = "Level1";
		L2 = "Level2";
		L3 = "Level3";
		L4 = "Level4";

		text = GetComponent <Text> ();


		score = 0;
	}


	void Update ()
	{
		//Debug.Log (Application.loadedLevelName);
		text.text = "Score: " + score;

		if (score == 30 && Application.loadedLevelName == L1) {

			//	currentdoor.localRotation = Quaternion.Slerp (currentdoor.localRotation, Quaternion.Euler (0, 90, 0), 3f);

			Application.LoadLevel("Level2");}
	
		if (score == 40 && Application.loadedLevelName == L2) {

		//	currentdoor.localRotation = Quaternion.Slerp (currentdoor.localRotation, Quaternion.Euler (0, 90, 0), 3f);

		Application.LoadLevel("Level3");}



		if (score == 70 && Application.loadedLevelName == L3) {

			//	currentdoor.localRotation = Quaternion.Slerp (currentdoor.localRotation, Quaternion.Euler (0, 90, 0), 3f);

			Application.LoadLevel("Level4");}
}

}


