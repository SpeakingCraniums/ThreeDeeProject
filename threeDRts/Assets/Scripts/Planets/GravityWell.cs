using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityWell : MonoBehaviour {

	private bool inWell;
	private GroundBehavior isItGroundUnit;

	void Start () {
		print (isItGroundUnit);
	}

	void OnTriggerEnter(Collider trapThis) {
		isItGroundUnit = trapThis.GetComponent<GroundBehavior>();
		print(isItGroundUnit);
		if (isItGroundUnit){
			print("insideifloop" + isItGroundUnit);
		}
	}
}
