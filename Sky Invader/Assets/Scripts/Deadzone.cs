using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

	// Referenssi LevelManager-luokkaan
	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		// Haetaan LevelManager-luokka
		levelManager = FindObjectOfType<LevelManager>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		// Tarkistuspiste aktivoituu kun sen läpi mennään.
		// LevelManager muistaa viimeisen tarkistuspisteen.

		// Oliko törmääjä pelihahmo?
		if (collision.tag == "Player") {
			// Törmääjä oli pelihahmo, joten sijoitetaan 
			// viimeisin tarkistuspiste muuttujaan
			levelManager.currentCheckPoint = gameObject;
			//Debug.Log("Aktiivinen tarkistuspiste: "+gameObject.name);
		}

	}


}
