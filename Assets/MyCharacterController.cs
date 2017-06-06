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
		
		// Recupero il gameobject che contiene il Collider intercettato
		GameObject go = other.gameObject;

		// Recupero il transform (posizione, rotazione e scala) del gameobject
		// che contiene il Collider intercettato
		Transform t = other.transform;

		// NOTA: scrivere
		//        other.gameobject.transform
		// oppure
		//        other.transform
		// è la medesima cosa (sono entrambe scorciatoie per lo stesso transform)
		//
		// allo stesso modo, scrivere
		//        other.transform.gameobject
		// ritorna lo stesso risultato di
		//        other.gameobject

		// Traccio a console il nome del gameobject
		Debug.Log ("Sei entrato in " + go.name);

		// Traccio a console la posizione del gameobject
		Debug.Log ("Che si trova in  " + t.position.x + ", " + t.position.y  + ", " + t.position.z);
	}
}
