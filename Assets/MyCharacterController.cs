using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour {

	// Use this for initialization
//	void Start () {
//		
//	}
	
	// Update is called once per frame
//	void Update () {    
//		
//	}

	void OnTriggerEnter(Collider other) {
		GameObject go = other.gameObject;
		Transform t = other.transform;

		Debug.Log ("Sei entrato in " + go.name);
		Debug.Log ("Che si trova in  " + t.position.x + ", " + t.position.y  + ", " + t.position.z);
	}
}
