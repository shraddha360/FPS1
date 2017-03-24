using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth4 : MonoBehaviour {

	// Use this for initialization
	public int scoreValue = 10;
	public int health = 3;


	// Use this for initialization
	void Start () {


	}

	void OnTriggerEnter (Collider collision)
	{

		if (collision.gameObject.tag == "Bullet") {
			Debug.Log("Decrease");
			health -= 1;

		}

		if (health == 0) {

			ScoreText.score += scoreValue;

			Destroy (this.gameObject);

		}

	}
}

