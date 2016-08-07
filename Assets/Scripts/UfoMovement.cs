using UnityEngine;
using System.Collections;

public class UfoMovement : MonoBehaviour {

	public float forceMultiplier;
	private Rigidbody2D ufoRigidBody;

	// Use this for initialization
	void Start () {
	
		ufoRigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Called before to apply physics
	void FixedUpdate () {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 forceVector = new Vector2 (moveHorizontal, moveVertical);

		ufoRigidBody.AddForce (forceVector * forceMultiplier);
	}
}
