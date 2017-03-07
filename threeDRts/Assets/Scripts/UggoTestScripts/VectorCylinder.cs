using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorCylinder : MonoBehaviour {

	public GameObject vectorTarget;
	public float gravity = 9.8f;
	private Vector3 vectorBetween;
	private Rigidbody sillyBody;

	// Update is called once per frame
	void Start(){
		sillyBody = GetComponent<Rigidbody>();
	}
	void Update () {
		vectorBetween = vectorTarget.transform.position - transform.position;
		print(vectorBetween.normalized);
		sillyBody.AddForce ( vectorBetween.normalized * gravity);
	}
}
