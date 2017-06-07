using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Gestisce le logiche del gioco
public class MyGameController : MonoBehaviour {

	// Riferimento al componente 'Confic' che contiene
	// gli elementi grafici per il gioco
	public Config config;

	// Indica se il gioco si trova in development mode,
	// e quindi non andrà a sostituire i materiali
	public bool devMode;

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
		// ed assegno al suo materiale quello dichiarato come 'TargetMaterial',
		// recuperato dal componente Config
		go.GetComponent<Renderer> ().material = config.TargetMaterial;

		// Cerco in scena un oggetto etichettato 'MinimapCharacter'
		// NOTA: per semplificare do per scontato che ne esista uno ed uno solo
		//       e che contenga un componente di tipo 'Renderer'
		GameObject character = GameObject.FindGameObjectWithTag ("MinimapCharacter");

		// Recupero il componente di tipo 'Renderer' all'interno del gameobject appena trovato
		// ed assegno al suo materiale quello dichiarato come 'CharacterMaterial',
		// recuperato dal componente Config
		character.GetComponent<Renderer> ().material = config.CharacterMaterial;

		// Recupero una lista degli elementi in scena che siano stati etichettati come 'EnvironmentElement'
		// NOTA: per semplificare do per scontato che ogni elemento della lista
		//       contenga un componente di tipo 'Renderer'
		GameObject[] goList = GameObject.FindGameObjectsWithTag ("EnvironmentElement");

		// Recupero un colore casuale dal 'Config'
		// NOTA: essendo dichiarato al di fuori del ciclo, ci assicura che
		//       tutti gli elementi recuperati avranno lo stesso colore
		Color c = config.GetRandomEnvironmentColor ();

		// Ciclo sugli elementi appena trovati
		foreach (GameObject element in goList) {
			
			// Traccio alla console il nome dell'elemento che sto considerando
			Debug.Log ("Element: " + element.name);

			// Recupero il componente di tipo 'Renderer' all'interno del gameobject 'element'
			// ed assegno al suo materiale quello dichiarato come 'EnvironmentMaterial',
			// recuperato dal componente Config
			element.GetComponent<Renderer> ().material = config.EnvironmentMaterial;

			// Assegno all'elemento il colore generato a caso precedentemente
			element.GetComponent<Renderer> ().material.color = c;
		}
	}	
}
