using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreText : MonoBehaviour
{
	public static int score;        
	public Transform currentdoor;
	Text text;                      

	void Awake ()
	{

		text = GetComponent <Text> ();


		score = 0;
	}


	void Update ()
	{
		
		text.text = "Score: " + score;

		if (score >= 30) {
			
			currentdoor.localRotation = Quaternion.Slerp (currentdoor.localRotation, Quaternion.Euler (0, 90, 0), 3f);

			Application.LoadLevel("Level2");}
	}
}


