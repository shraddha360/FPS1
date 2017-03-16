using UnityEngine;
using System.Collections;

public class BulletFire : MonoBehaviour
{
	
	public GameObject Bullet_Emitter;


	public GameObject Bullet;

	public float Bullet_Forward_Force;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.F)) {
			GameObject Temporary_Bullet_Handler;
			Temporary_Bullet_Handler = Instantiate (Bullet, transform.position, transform.rotation) as GameObject;

	
			Temporary_Bullet_Handler.transform.Rotate (Vector3.left * Bullet_Forward_Force );

			Rigidbody Temporary_RigidBody;
			Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody> ();

			Temporary_RigidBody.AddForce (transform.right  * Bullet_Forward_Force);


			Destroy (Temporary_Bullet_Handler, 2.0f);

		
		}


	}

}