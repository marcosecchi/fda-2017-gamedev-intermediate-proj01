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

	// Quando il gameobject cui appartiene questo componente entra in un trigger,
	// stampa alla console il nome dell'oggetto cui appartiene il trigger e la sua posizione
	void OnTriggerEnter(Collider other) {
		GameObject go = other.gameObject;
		Transform t = other.transform;

		Debug.Log ("Sei entrato in " + go.name);
		Debug.Log ("Che si trova in  " + t.position.x + ", " + t.position.y  + ", " + t.position.z);
	}
}
