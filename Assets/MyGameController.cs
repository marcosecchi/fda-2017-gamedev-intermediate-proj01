using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Gestisce le logiche del gioco
public class MyGameController : MonoBehaviour {

	// Indica se il gioco si trova in development mode,
	// e quindi non andrà a sostituire i materiali
	public bool devMode;

	// Materiale degli oggetti in scena
	public Material environmentMaterial;

	// Materiale dell'oggetto da raggiungere
	public Material targetMaterial;

	// Callback di Unity per inizializzare la scena
	void Start () {
		// Se ci si trova in devMode, si ritorna senza effettuare nulla
		if (devMode)
			return;
		
		GameObject go = GameObject.Find ("Target");
		go.GetComponent<Renderer> ().material = targetMaterial;

		GameObject[] goList = GameObject.FindGameObjectsWithTag ("EnvironmentElement");
		foreach (GameObject element in goList) {
			Debug.Log (element);
			element.GetComponent<Renderer> ().material = environmentMaterial;
		}
	}
	
}
