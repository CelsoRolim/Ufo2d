using UnityEngine;
using System.Collections;

public class PickupMovement : MonoBehaviour {

	public float rotationFactor;

	// Update is called once per frame
	void Update () {

		Vector3 rotationVector = new Vector3 (0, 0, rotationFactor);
		transform.Rotate(rotationVector * Time.deltaTime);
	}

	void OnTriggerEnter2D() 
	{
		GameManager.instance.HitCollectables ();
		Destroy (gameObject);
	}
}
