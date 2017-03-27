using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreText : MonoBehaviour
{

	public GameObject Canvas;
	public static int score;  
	public bool waitpan ;


//	public Transform currentdoor;
	Text text;   
	public string L1, L2, L3, L4,L5;
	 
	public GameObject Spidy;
	public GameObject Kill;




	void Start ()

	{




		L1 = "Level1";
		L2 = "Level2";
		L3 = "Level3";
		L4 = "Level4";
		L5 = "Level5";


		if (Application.loadedLevelName == L5)
		{
			Spidy = GameObject.Find ("spider");
			Spidy.SetActive (false);

			Canvas = GameObject.Find ("End");
			Canvas.SetActive (false);
			 

			Kill = GameObject.Find ("Kill");
			Kill.SetActive (false);


		}


	
		text = GetComponent <Text> ();


		score = 0;
	}


	void Update ()
	{
		//Debug.Log (Application.loadedLevelName);
		text.text = "Score: " + score;

		if (score == 30 && Application.loadedLevelName == L1) {

			//	currentdoor.localRotation = Quaternion.Slerp (currentdoor.localRotation, Quaternion.Euler (0, 90, 0), 3f);

			Application.LoadLevel ("Level2");
		}
	
		if (score == 40 && Application.loadedLevelName == L2) {

			//	currentdoor.localRotation = Quaternion.Slerp (currentdoor.localRotation, Quaternion.Euler (0, 90, 0), 3f);

			Application.LoadLevel ("Level3");
		}



		if (score == 70 && Application.loadedLevelName == L3) {

			//	currentdoor.localRotation = Quaternion.Slerp (currentdoor.localRotation, Quaternion.Euler (0, 90, 0), 3f);

			Application.LoadLevel ("Level4");
		}

		if (score == 50 && Application.loadedLevelName == L4) {

			//	currentdoor.localRotation = Quaternion.Slerp (currentdoor.localRotation, Quaternion.Euler (0, 90, 0), 3f);

			Application.LoadLevel ("Level5");
		}



		if (score == 50 && Application.loadedLevelName == L5 && waitpan==false) {


			Kill.SetActive (true);
			Spidy.SetActive (true);
			Invoke("wait",2f);



		}

		if (score == 100 && Application.loadedLevelName == L5) {
			
			Canvas.gameObject.SetActive (true);
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			Time.timeScale = 0;

		}
	}
		void wait(){
		waitpan = true;
		Kill.SetActive (false);



		}
	}


		






