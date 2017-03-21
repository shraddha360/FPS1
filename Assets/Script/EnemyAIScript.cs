using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIScript : MonoBehaviour {

	public Transform player;
	public float playerDistance;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		playerDistance = Vector3.Distance (player.position, transform.position);

		if (playerDistance <= 15f);

	}
}
