using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config : MonoBehaviour {

	// Materiale degli oggetti in scena
	// NOTA: 'SerializeField' ci assicura che l'attributo sia visibile
	//       all'interno della scena. 'Private' rende inaccessibile l'attributo
	//       all'esterno
	[SerializeField]
	private Material _environmentMaterial;

	// Materiale dell'oggetto da raggiungere
	[SerializeField]
	private Material _targetMaterial;

	// Materiale del personaggio
	[SerializeField]
	private Material _characterMaterial;

	// Elenco dei colori disponibili per gli elementi dell'ambiente
	[SerializeField]
	private Color[] _environmentColors;

	// Getter per il materiale dell'Environment
	public Material EnvironmentMaterial {
		get { 
			return _environmentMaterial;
		}
	}

	// Getter per il materiale del Target
	public Material TargetMaterial {
		get { 
			return _targetMaterial;
		}
	}

	// Getter per il materiale del Character (per la minimap)
	public Material CharacterMaterial {
		get { 
			return _characterMaterial;
		}
	}

	// Ritorna il colore all'indice 'index', assicurandosi che
	// non sia un valore al difuori di quelli possibili
	public Color GetEnvironmentColor(int index) {
		if (index >= _environmentColors.Length)
			index = 0;
		return _environmentColors [index];
	}

	// Ritorna un colore a caso dalla lista di quelli disponibili
	public Color GetRandomEnvironmentColor() {
		var index = Random.Range (0, _environmentColors.Length);
		return _environmentColors[index];
	}
}
