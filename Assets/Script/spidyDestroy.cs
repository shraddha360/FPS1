using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spidyDestroy : MonoBehaviour {

	public int scoreValue = 50;

	public int health = 10;


	// Use this for initialization
	void Start () {


	}

	void OnCollisionEnter (Collision collision)
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

