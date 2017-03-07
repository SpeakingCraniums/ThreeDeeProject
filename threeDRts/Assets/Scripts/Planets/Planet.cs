using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour {
	//will need spin and stuff

	public Vector3 gravHome;
	private SphereCollider planetCollider;
	public float radiusOfPlanet;

	void Start () {
		gravHome = transform.position;
		planetCollider = GetComponent<SphereCollider>();
		radiusOfPlanet = planetCollider.radius;
	}
	
	// Update is called once per frame
	void Update () {
			
	}
}
