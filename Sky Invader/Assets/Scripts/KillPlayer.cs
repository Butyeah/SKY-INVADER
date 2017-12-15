using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	// YHteys LevelManageriin
	private LevelManager levelManager;

	// Use this for initialization
	void Start () {

		levelManager = FindObjectOfType<LevelManager>();

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{

			// Siirretään pelihahmo viimeiseen tarkistuspisteeseen
			levelManager.RespanPlayer();
		}
	}
}
