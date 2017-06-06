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
		// Se ci si trova in devMode, si esce dalla funzione
		// senza effettuare nessuna operazione
		if (devMode)
			return;

		// Cerco in scena un oggetto chiamato 'Target'
		// NOTA: per semplificare do per scontato che ne esista uno ed uno solo
		//       e che contenga un componente di tipo 'Renderer'
		GameObject go = GameObject.Find ("Target");

		// Traccio alla console il nome dell'oggetto appena trovato
		Debug.Log ("Target: " + go);

		// Recupero il componente di tipo 'Renderer' all'interno del gameobject appena trovato
		// ed assegno al suo materiale quello dichiarato come 'targetMaterial'
		go.GetComponent<Renderer> ().material = targetMaterial;

		// Recupero una lista degli elementi in scena che siano stati etichettati come 'EnvironmentElement'
		// NOTA: per semplificare do per scontato che ogni elemento della lista
		//       contenga un componente di tipo 'Renderer'
		GameObject[] goList = GameObject.FindGameObjectsWithTag ("EnvironmentElement");

		// Ciclo sugli elementi appena trovati
		foreach (GameObject element in goList) {
			
			// Traccio alla console il nome dell'elemento che sto considerando
			Debug.Log ("Element: " + element);

			// Recupero il componente di tipo 'Renderer' all'interno del gameobject 'element'
			// ed assegno al suo materiale quello dichiarato come 'environmentMaterial'
			element.GetComponent<Renderer> ().material = environmentMaterial;
		}
	}	
}
