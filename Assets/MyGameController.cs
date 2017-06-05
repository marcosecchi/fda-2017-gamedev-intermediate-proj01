using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameController : MonoBehaviour {

	public bool debugMode;

	public Material environmentMaterial;
	public Material targetMaterial;

	// Use this for initialization
	void Start () {
		if (debugMode)
			return;
		
		GameObject go = GameObject.Find ("Target");
		go.GetComponent<Renderer> ().material = targetMaterial;
		GameObject[] goList = GameObject.FindGameObjectsWithTag ("EnvironmentElement");
		foreach (GameObject element in goList) {
			Debug.Log (element);
			element.GetComponent<Renderer> ().material = environmentMaterial;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
