using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class EnemyDestroy : MonoBehaviour {
	
	public int scoreValue = 10;



	void OnCollisionEnter(Collision collision){


		if(collision.gameObject.tag == "Bullet")
		{

			Debug.Log ("Destroy");


			//Destroy (collision.gameObject);

			ScoreText.score += scoreValue;

			Destroy(this.gameObject);

		



		}
	}

}